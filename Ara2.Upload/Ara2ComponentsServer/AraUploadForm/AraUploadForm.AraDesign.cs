
/*
    NÂO ALTERAR ESTE ARQUIVO SEM O EDITOR ARA.DEV !
    DO NOT CHANGE THIS FILE WITHOUT THE EDITOR ARA.DEV!

 _   _          ____             _   _______ ______ _____            _____    ______  _____ _______ ______            _____   ____  _    _ _______      ______  
| \ | |   /\   / __ \      /\   | | |__   __|  ____|  __ \     /\   |  __ \  |  ____|/ ____|__   __|  ____|     /\   |  __ \ / __ \| |  | |_   _\ \    / / __ \ 
|  \| |  /  \ | |  | |    /  \  | |    | |  | |__  | |__) |   /  \  | |__) | | |__  | (___    | |  | |__       /  \  | |__) | |  | | |  | | | |  \ \  / / |  | |
| . ` | / /\ \| |  | |   / /\ \ | |    | |  |  __| |  _  /   / /\ \ |  _  /  |  __|  \___ \   | |  |  __|     / /\ \ |  _  /| |  | | |  | | | |   \ \/ /| |  | |
| |\  |/ ____ \ |__| |  / ____ \| |____| |  | |____| | \ \  / ____ \| | \ \  | |____ ____) |  | |  | |____   / ____ \| | \ \| |__| | |__| |_| |_   \  / | |__| |
|_| \_/_/    \_\____/  /_/    \_\______|_|  |______|_|  \_\/_/    \_\_|  \_\ |______|_____/   |_|  |______| /_/    \_\_|  \_\\___\_\\____/|_____|   \/   \____/ 
                                                                                                                                                                

Ara2.Dev 1.0

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ara2;
using Ara2.Components;


namespace AraDesign
{
    [Serializable]
    public abstract class AraUploadFormAraDesign : Ara2.Components.AraWindow
    {
    
       #region Objects
       private AraObjectInstance<Ara2.Components.Upload.AraUpload> _Upload = new AraObjectInstance<Ara2.Components.Upload.AraUpload>();
       public Ara2.Components.Upload.AraUpload Upload
       {
          get { return _Upload.Object; }
          set { _Upload.Object = value; }
       }
       private AraObjectInstance<Ara2.Components.AraLabel> _A0O122 = new AraObjectInstance<Ara2.Components.AraLabel>();
       public Ara2.Components.AraLabel A0O122
       {
          get { return _A0O122.Object; }
          set { _A0O122.Object = value; }
       }
       private AraObjectInstance<Ara2.Components.AraButton> _bFechar = new AraObjectInstance<Ara2.Components.AraButton>();
       public Ara2.Components.AraButton bFechar
       {
          get { return _bFechar.Object; }
          set { _bFechar.Object = value; }
       }
       #endregion 
       #region Events
       public abstract System.Boolean Upload_ReceiveFile(System.String vFile);
       public abstract void Upload_ReceiveFileComplite(System.String vFile);
       public abstract void bFechar_Click(System.Object sender,System.EventArgs e);
       #endregion 
        public AraUploadFormAraDesign(IAraContainerClient vConteiner)
            : base(vConteiner)
        {
            #region Instances
            #region Propertys Main
            this.Title  = @"Envie os Arquivos";
            this.ZIndexWindow  = 1000004;
            this.ButtonClose  = false;
            this.Visible  = false;
            this.Width  =  new Ara2.Components.AraDistance(@"476px");
            this.Height  =  new Ara2.Components.AraDistance(@"340px");
            #endregion
            
            
            #region Upload
            this.Upload = new Ara2.Components.Upload.AraUpload(this);

            this.Upload.Name = "Upload";
            this.Upload.Anchor.Left  = 5;
            this.Upload.Anchor.Top  = 40;
            this.Upload.Anchor.Right  = 5;
            this.Upload.Anchor.Bottom  = 5;
            this.Upload.Left  =  new Ara2.Components.AraDistance(@"5px");
            this.Upload.Top  =  new Ara2.Components.AraDistance(@"40px");
            this.Upload.MinWidth  =  new Ara2.Components.AraDistance(@"150px");
            this.Upload.MinHeight  =  new Ara2.Components.AraDistance(@"50px");
            this.Upload.Width  =  new Ara2.Components.AraDistance(@"466px");
            this.Upload.Height  =  new Ara2.Components.AraDistance(@"295px");
            this.Upload.ZIndex  = 1;
            this.Upload.PathSaveFiles  = @"C:\Program Files\Tecnomips\Ara2.Dev\UploadFiles\";
            this.Upload.ReceiveFile  += Upload_ReceiveFile;
            this.Upload.ReceiveFileComplite  += Upload_ReceiveFileComplite;
            #endregion
            #region A0O122
            this.A0O122 = new Ara2.Components.AraLabel(this);

            this.A0O122.Name = "A0O122";
            this.A0O122.Text  = @"Arraste os arquivos em cima do botão vermelho";
            this.A0O122.Anchor.Left  = 5;
            this.A0O122.Anchor.Top  = 5;
            this.A0O122.Anchor.Right  = 5;
            this.A0O122.Left  =  new Ara2.Components.AraDistance(@"5px");
            this.A0O122.Top  =  new Ara2.Components.AraDistance(@"4px");
            this.A0O122.MinWidth  =  new Ara2.Components.AraDistance(@"10px");
            this.A0O122.MinHeight  =  new Ara2.Components.AraDistance(@"17px");
            this.A0O122.Width  =  new Ara2.Components.AraDistance(@"466px");
            this.A0O122.Height  =  new Ara2.Components.AraDistance(@"30px");
            this.A0O122.ZIndex  = 2;
            #endregion
            #region bFechar
            this.bFechar = new Ara2.Components.AraButton(this);

            this.bFechar.Name = "bFechar";
            this.bFechar.Text  = @"Sair";
            this.bFechar.Left  =  new Ara2.Components.AraDistance(@"364px");
            this.bFechar.Top  =  new Ara2.Components.AraDistance(@"4px");
            this.bFechar.MinWidth  =  new Ara2.Components.AraDistance(@"10px");
            this.bFechar.MinHeight  =  new Ara2.Components.AraDistance(@"25px");
            this.bFechar.Width  =  new Ara2.Components.AraDistance(@"105px");
            this.bFechar.Height  =  new Ara2.Components.AraDistance(@"25px");
            this.bFechar.ZIndex  = 3;
            this.bFechar.Click  += bFechar_Click;
            #endregion
            #endregion
        } 
    } 
} 
