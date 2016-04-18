
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
    public abstract class DivMainAraDesign : Ara2.Components.AraDiv
    {
    
       #region Objects
       private AraObjectInstance<Ara2.Components.AraDiv> _A0O215 = new AraObjectInstance<Ara2.Components.AraDiv>();
       public Ara2.Components.AraDiv A0O215
       {
          get { return _A0O215.Object; }
          set { _A0O215.Object = value; }
       }
       private AraObjectInstance<Ara2.Components.AraButton> _bSimples = new AraObjectInstance<Ara2.Components.AraButton>();
       public Ara2.Components.AraButton bSimples
       {
          get { return _bSimples.Object; }
          set { _bSimples.Object = value; }
       }
       private AraObjectInstance<Ara2.Components.AraLabel> _A0O240 = new AraObjectInstance<Ara2.Components.AraLabel>();
       public Ara2.Components.AraLabel A0O240
       {
          get { return _A0O240.Object; }
          set { _A0O240.Object = value; }
       }
       #endregion 
       #region Events
       public abstract void bSimples_Click(System.Object sender,System.EventArgs e);
       #endregion 
        public DivMainAraDesign(IAraContainerClient vConteiner)
            : base(vConteiner)
        {
            #region Instances
            #region Propertys Main
            this.Visible  = false;
            this.Left  =  new Ara2.Components.AraDistance(@"0px");
            this.Top  =  new Ara2.Components.AraDistance(@"0px");
            this.MinWidth  =  new Ara2.Components.AraDistance(@"10px");
            this.MinHeight  =  new Ara2.Components.AraDistance(@"10px");
            this.Width  =  new Ara2.Components.AraDistance(@"577px");
            this.Height  =  new Ara2.Components.AraDistance(@"196px");
            #endregion
            
            
            #region A0O215
            this.A0O215 = new Ara2.Components.AraDiv(this);

            this.A0O215.Name = "A0O215";
            this.A0O215.StyleContainer  = true;
            this.A0O215.Left  =  new Ara2.Components.AraDistance(@"12px");
            this.A0O215.Top  =  new Ara2.Components.AraDistance(@"17px");
            this.A0O215.MinWidth  =  new Ara2.Components.AraDistance(@"10px");
            this.A0O215.MinHeight  =  new Ara2.Components.AraDistance(@"10px");
            this.A0O215.Width  =  new Ara2.Components.AraDistance(@"150px");
            this.A0O215.Height  =  new Ara2.Components.AraDistance(@"155px");
            this.A0O215.ZIndex  = 1;
            #endregion
            #region bSimples
            this.bSimples = new Ara2.Components.AraButton(this.A0O215);

            this.bSimples.Name = "bSimples";
            this.bSimples.Text  = @"Simples";
            this.bSimples.Anchor.Left  = 5;
            this.bSimples.Anchor.Right  = 5;
            this.bSimples.Left  =  new Ara2.Components.AraDistance(@"5px");
            this.bSimples.Top  =  new Ara2.Components.AraDistance(@"32px");
            this.bSimples.MinWidth  =  new Ara2.Components.AraDistance(@"10px");
            this.bSimples.MinHeight  =  new Ara2.Components.AraDistance(@"25px");
            this.bSimples.Width  =  new Ara2.Components.AraDistance(@"140px");
            this.bSimples.Height  =  new Ara2.Components.AraDistance(@"25px");
            this.bSimples.ZIndex  = 1;
            this.bSimples.Click  += bSimples_Click;
            #endregion
            #region A0O240
            this.A0O240 = new Ara2.Components.AraLabel(this.A0O215);

            this.A0O240.Name = "A0O240";
            this.A0O240.Text  = @"Upload";
            this.A0O240.Left  =  new Ara2.Components.AraDistance(@"5px");
            this.A0O240.Top  =  new Ara2.Components.AraDistance(@"4px");
            this.A0O240.MinWidth  =  new Ara2.Components.AraDistance(@"10px");
            this.A0O240.MinHeight  =  new Ara2.Components.AraDistance(@"17px");
            this.A0O240.Width  =  new Ara2.Components.AraDistance(@"100px");
            this.A0O240.Height  =  new Ara2.Components.AraDistance(@"17px");
            this.A0O240.ZIndex  = 2;
            #endregion
            #endregion
        } 
    } 
} 
