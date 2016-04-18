using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using Ara2;
using Ara2.Components;
using System.Reflection;
using System.IO;
using System.Text;


namespace Ara2.Upload.Teste.Forms
{
    [Serializable]
    public class FrmMain : WindowMain
    {
        private AraObjectInstance<DivMain> _DivMain = new AraObjectInstance<DivMain>();
        public DivMain DivMain
        {
            get { return _DivMain.Object; }
            set { _DivMain.Object = value; }
        }

        public FrmMain(Ara2.Session Session)
            : base(Session)
        {
            DivMain = new DivMain(this);
            DivMain.Anchor.Left = 5;
            DivMain.Anchor.Top = 5;
            DivMain.Anchor.Right = 5;
            DivMain.Anchor.Bottom = 5;
            DivMain.Visible = true;
        }

        public override string GetBodyHtml()
        {
            return "<title>Ara2 jqPlot Teste</title>";
        }

        public static FrmMain GetInstance()
        {
            return ((FrmMain)Tick.GetTick().Session.WindowMain);
        }

    }

}