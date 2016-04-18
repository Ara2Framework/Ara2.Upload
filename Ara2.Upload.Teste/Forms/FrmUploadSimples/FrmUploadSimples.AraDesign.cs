
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
    public abstract class FrmUploadSimplesAraDesign : Ara2.Components.AraWindow
    {
    
       #region Objects
       private AraObjectInstance<Ara2.Components.AraButton> _bSair = new AraObjectInstance<Ara2.Components.AraButton>();
       public Ara2.Components.AraButton bSair
       {
          get { return _bSair.Object; }
          set { _bSair.Object = value; }
       }
       private AraObjectInstance<Ara2.Components.Upload.AraUpload> _Upload = new AraObjectInstance<Ara2.Components.Upload.AraUpload>();
       public Ara2.Components.Upload.AraUpload Upload
       {
          get { return _Upload.Object; }
          set { _Upload.Object = value; }
       }
       #endregion 
       #region Events
       public abstract void bSair_Click(System.Object sender,System.EventArgs e);
       public abstract System.Boolean Upload_ReceiveFile(System.String vFile);
       public abstract void Upload_ReceiveFileComplite(System.String vFile);
       #endregion 
        public FrmUploadSimplesAraDesign(IAraContainerClient vConteiner)
            : base(vConteiner)
        {
            #region Instances
            #region Propertys Main
            this.ZIndexWindow  = 1000004;
            this.Visible  = false;
            this.Width  =  new Ara2.Components.AraDistance(@"509px");
            this.Height  =  new Ara2.Components.AraDistance(@"308px");
            #endregion
            
            
            #region bSair
            this.bSair = new Ara2.Components.AraButton(this);

            this.bSair.Name = "bSair";
            this.bSair.Text  = @"Sair";
            this.bSair.Anchor.Right  = 5;
            this.bSair.Left  =  new Ara2.Components.AraDistance(@"414px");
            this.bSair.Top  =  new Ara2.Components.AraDistance(@"8px");
            this.bSair.MinWidth  =  new Ara2.Components.AraDistance(@"10px");
            this.bSair.MinHeight  =  new Ara2.Components.AraDistance(@"25px");
            this.bSair.Width  =  new Ara2.Components.AraDistance(@"90px");
            this.bSair.Height  =  new Ara2.Components.AraDistance(@"25px");
            this.bSair.ZIndex  = 1;
            this.bSair.Click  += bSair_Click;
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
            this.Upload.Width  =  new Ara2.Components.AraDistance(@"499px");
            this.Upload.Height  =  new Ara2.Components.AraDistance(@"263px");
            this.Upload.ZIndex  = 2;
            this.Upload.PathSaveFiles  = @"D:\Tecnomips\Ara.Net2\Ara2.Dev\Ara2.Dev\UploadFiles\";
            this.Upload.ReceiveFile  += Upload_ReceiveFile;
            this.Upload.ReceiveFileComplite  += Upload_ReceiveFileComplite;
            #endregion
            #endregion
        } 
    } 
} 
