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
    public class DivMain : AraDesign.DivMainAraDesign
    {
        public DivMain(IAraContainerClient ConteinerFather)
            : base(ConteinerFather)
        {


        }

        public override void bSimples_Click(object sender, EventArgs e)
        {
            FrmUploadSimples FrmUploadSimples = new FrmUploadSimples(this);
            FrmUploadSimples.Show();
        }

        
    }
}