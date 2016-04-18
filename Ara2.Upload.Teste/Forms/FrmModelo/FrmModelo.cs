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
    public class FrmModelo : AraDesign.FrmModeloAraDesign
    {
        public FrmModelo(IAraContainerClient ConteinerFather)
            : base(ConteinerFather)
        {


        }

        

    }
}