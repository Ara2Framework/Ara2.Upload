using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ara2;
using Ara2.Components;
using Ara2.Dev;

namespace Ara2.Components.Upload
{
    [Serializable]
    [AraDevComponent(vConteiner: false)]
    public class AraUploadButton:AraButton
    {
        public AraUploadButton(IAraObject ConteinerFather):
            base(ConteinerFather)
        {
            this.Click += this_Click;
        }

        public delegate void DReceiveFiles(List<string> Files);

        [AraDevEvent]
        public AraEvent<DReceiveFiles> ReceiveFile = new AraEvent<DReceiveFiles>();


        private void this_Click(object sender, EventArgs e)
        {
            if (ReceiveFile.InvokeEvent != null)
            {
                AraUploadForm AraUploadForm = new AraUploadForm(this);
                AraUploadForm.PathSaveFiles = _PathSaveFiles;
                AraUploadForm.Show(AraUploadForm_return);
            }
        }

        private void AraUploadForm_return(object vObj)
        {
            if (vObj != null)
            {
                if (ReceiveFile.InvokeEvent != null)
                    ReceiveFile.InvokeEvent((List<string>)vObj);
            }
        }

        string _PathSaveFiles = "";
        [AraDevProperty("")]
        public string PathSaveFiles
        {
            get { return _PathSaveFiles; }
            set { _PathSaveFiles = value; }
        }
    }
}