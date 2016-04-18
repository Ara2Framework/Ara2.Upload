using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.IO;
using Ara2.Components;
using Ara2;

namespace Ara2.Components.Upload
{
    [Serializable]
    public class AraUploadForm : AraDesign.AraUploadFormAraDesign
    {
        public AraUploadForm(IAraContainerClient ConteinerFather)
            : base(ConteinerFather)
        {


        }

        

        public AraEvent<AraUpload.DReceiveFile> ReceiveFile = new AraEvent<AraUpload.DReceiveFile>();
        public override bool Upload_ReceiveFile(string vFile)
        {
            if (ReceiveFile.InvokeEvent!=null)
                return ReceiveFile.InvokeEvent(vFile);
            else
                return true;
        }

        List<string> Files = new List<string>();

        public AraEvent<AraUpload.DReceiveFileComplite> ReceiveFileComplite = new AraEvent<AraUpload.DReceiveFileComplite>();
        public override void Upload_ReceiveFileComplite(string vFile)
        {
            if (ReceiveFileComplite.InvokeEvent != null)
                ReceiveFileComplite.InvokeEvent(vFile);

            Files.Add(Path.Combine(Upload.PathSaveFiles, vFile));
        }

        public string PathSaveFiles
        {
            get { return Upload.PathSaveFiles; }
            set { Upload.PathSaveFiles = value; }
        }

        public override void bFechar_Click(object sender, EventArgs e)
        {
            this.Close(Files);
        }

    }
}