using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using Ara2;
using Ara2.Components.Textbox;
using Ara2.Dev;
using System.Reflection;
using System.Net;

namespace Ara2.Components.Upload
{
    [Serializable]
    [AraDevComponent(vConteiner:false)]
    public class AraUpload : AraComponentVisualAnchorConteiner, IAraDev
    {

        public AraUpload(IAraObject ConteinerFather)
            : this(AraObjectClienteServer.Create(ConteinerFather, "div"), ConteinerFather)
        {
            
        }
        public AraUpload(string vId, IAraObject ConteinerFather)
            : base(vId, ConteinerFather, "AraUpload")
        {
            Click = new AraComponentEvent<EventHandler>(this, "Click");
            PathSaveFiles = AraTools.GetPath() + "UploadFiles\\";
            this.EventInternal += this_EventInternal ;
            this.MinWidth = 150;
            this.MinHeight = 50;
            this.Width = 110;
            this.Height = 25;
        }

        [AraDevProperty("")]
        public string PathSaveFiles = "";

        public delegate bool DReceiveFile(string vFile);
        /// <summary>
        /// Usado para validar se o arquivo é permitido ! Não manipular objetos de interface!!!
        /// </summary>
        [AraDevEvent]
        public AraEvent<DReceiveFile> ReceiveFile = new AraEvent<DReceiveFile>();


        public delegate void DReceiveFileComplite(string vFile);
        /// <summary>
        /// Quando o arquivo é recebido
        /// </summary>
        [AraDevEvent]
        public AraEvent<DReceiveFileComplite> ReceiveFileComplite = new AraEvent<DReceiveFileComplite>();

        [AraDevEvent]
        AraComponentEvent<EventHandler> Click;

        public override void LoadJS()
        {
            Tick vTick = Tick.GetTick();
            vTick.Session.AddCss("Ara2/Components/AraUpload/files/fileuploader.css");
            vTick.Session.AddJs("Ara2/Components/AraUpload/files/fileuploader.js");
            vTick.Session.AddJs("Ara2/Components/AraUpload/AraUpload.js");
        }


        private void this_EventInternal(String vFunction)
        {
            switch (vFunction.ToUpper())
            {
                case "CLICK":
                    Click.InvokeEvent(this, new EventArgs());
                    break;
                case "SENDFILE":
                {
                    Tick Tick = Tick.GetTick();
                    try
                    {
                        //string vFileName = Client.Page.Request["qqfile"];

                        String filename;

                        if (Tick.Page.Request.Files.AllKeys.Length > 0)
                            filename = HttpUtility.UrlDecode(Tick.Page.Request.Files[0].FileName);
                        else
                            filename = HttpUtility.UrlDecode(Tick.Page.Request.Headers["X-File-Name"]);



                        bool Permitido = true;
                        if (ReceiveFile.InvokeEvent != null)
                            Permitido = ReceiveFile.InvokeEvent(filename);


                        if (Permitido)
                        {
                            try
                            {
                                if (!Directory.Exists(PathSaveFiles))
                                    Directory.CreateDirectory(PathSaveFiles);
                                if (File.Exists(Path.Combine(PathSaveFiles, Path.GetFileName(filename))))
                                    File.Delete(Path.Combine(PathSaveFiles, Path.GetFileName(filename)));

                                if (Tick.Page.Request.Files.AllKeys.Length > 0) // IE
                                {
                                    HttpPostedFile file = Tick.Page.Request.Files[0];
                                    file.SaveAs(Path.Combine(PathSaveFiles, Path.GetFileName(filename)));
                                }
                                else // Outros
                                {
                                    using (Stream inputStream = HttpContext.Current.Request.InputStream)
                                    {
                                        using (FileStream fileStream = new FileStream(Path.Combine(PathSaveFiles, Path.GetFileName(filename)), FileMode.OpenOrCreate))
                                        {
                                            inputStream.CopyTo(fileStream);
                                            fileStream.Close();
                                        }
                                    }
                                }

                                Tick.Script.CallObject(this);
                                Tick.Script.Send("vObj.ResponseUploadJson({success:true, name:\"" + AraTools.StringToStringJS(filename) + "\"});");

                                try
                                {
                                    if (ReceiveFileComplite != null)
                                        ReceiveFileComplite.InvokeEvent(Path.GetFileName(filename));
                                }
                                catch { }
                                // Codigo para receber arquivo


                            }
                            catch (Exception err)
                            {
                                this.TickScriptCall();
                                Tick.Script.Send("vObj.ResponseUploadJson({'error': 'Falha ao receber arquivo. " + AraTools.StringToStringJS(err.Message) + "'});");
                            }
                        }
                        else
                        {
                            this.TickScriptCall();
                            Tick.Script.Send("vObj.ResponseUploadJson({'error': 'Arquivo não permitido'});");
                        }

                    }
                    catch (Exception err)
                    {
                        this.TickScriptCall();
                        Tick.Script.Send("vObj.ResponseUploadJson({'error': 'Falha generica ao receber arquivo. " + AraTools.StringToStringJS(err.Message) + "'});");
                    }
                }
                break;
            }
        }
        
        private bool _Enabled = true;
        [AraDevProperty(true)]
        public bool Enabled
        {
            get { return _Enabled; }
            set
            {
                _Enabled = value;
                
                this.TickScriptCall();
                Tick.GetTick().Script.Send(" vObj.SetEnabled(" + (_Enabled == true ? "true" : "false") + "); \n");
            }
        }

        private string _Text = "Enviar";
        [AraDevProperty("Enviar")]
        public string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                
                this.TickScriptCall();
                Tick.GetTick().Script.Send(" vObj.SetText('" + AraTools.StringToStringJS(_Text) + "'); \n");
            }
        }

        private string _ButtonCancel = "Cancelar";
        [AraDevProperty("Cancelar")]
        public string ButtonCancel
        {
            get { return _ButtonCancel; }
            set
            {
                _ButtonCancel = value;

                this.TickScriptCall();
                Tick.GetTick().Script.Send(" vObj.SetcancelButtonText('" + AraTools.StringToStringJS(_ButtonCancel) + "'); \n");
            }
        }

        private string _FailUploadText = "Envio Falhou";
        [AraDevProperty("Envio Falhou")]
        public string FailUploadText
        {
            get { return _FailUploadText; }
            set
            {
                _FailUploadText = value;

                this.TickScriptCall();
                Tick.GetTick().Script.Send(" vObj.SetFailUploadText('" + AraTools.StringToStringJS(_FailUploadText) + "'); \n");
            }
        }

        #region Ara2Dev
        private string _Name = "";
        [AraDevProperty("")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private AraEvent<DStartEditPropertys> _StartEditPropertys = null;
        public AraEvent<DStartEditPropertys> StartEditPropertys
        {
            get
            {
                if (_StartEditPropertys == null)
                {
                    _StartEditPropertys = new AraEvent<DStartEditPropertys>();
                    this.Click += this_ClickEdit;
                }

                return _StartEditPropertys;
            }
            set
            {
                _StartEditPropertys = value;
            }
        }
        private void this_ClickEdit(object sender, EventArgs e)
        {
            if (_StartEditPropertys.InvokeEvent != null)
                _StartEditPropertys.InvokeEvent(this);
        }

        private AraEvent<DStartEditPropertys> _ChangeProperty = new AraEvent<DStartEditPropertys>();
        public AraEvent<DStartEditPropertys> ChangeProperty
        {
            get
            {
                return _ChangeProperty;
            }
            set
            {
                _ChangeProperty = value;
            }
        }
        #endregion

        

    }
}
