using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ara2;
using System.Web.Configuration; 

namespace Ara2.Upload.Teste
{
    public partial class _Default : AraPageMain
    {
        public override Ara2.Memory.IAraMemoryArea GetMemoryArea()
        {
            return new Ara2.Memory.AraMemoryAreaPool();
        }

        public override Ara2.Components.WindowMain GetWindowMain(Ara2.Session Session)
        {
            return new Forms.FrmMain(Session);
        }

        public override void ExceptionAplication(Exception err)
        {
            AraTools.Alert( err.Message);
        }

        public override string GetJQueryUICss()
        {
            return base.GetJQueryUICss();
        }

        //public override string ViewPort()
        //{
        //    //return "target-densitydpi=device-dpi; width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;";
        //    return Config.Get["ViewPort"];
        //}
    }
}