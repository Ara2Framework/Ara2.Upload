using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.IO;
using Ara2.Components;
using Ara2;
using System.Web.Configuration;

namespace Ara2.Upload.Teste.Forms
{
    [Serializable]
    public class FrmUploadSimples : AraDesign.FrmUploadSimplesAraDesign
    {
        public FrmUploadSimples(IAraContainerClient ConteinerFather)
            : base(ConteinerFather)
        {

            Upload.Text = "Teste !";
        }

        public override void bSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override bool Upload_ReceiveFile(string vFile)
        {
            return Path.GetExtension(vFile).ToLower() == ".png";
        }

        public override void Upload_ReceiveFileComplite(string vFile)
        {
            
        }

    }
}