using DevExpress.XtraBars.Docking;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DockManagerTest
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         InitializeComponent( );
      }

      private DockManager _dm;
      public DockManager dm
      {
         get
         {
            if( this._dm == null )
            {
               // Create a dock manager and initialize its Form property. 
               this._dm = new DockManager( this );
            }
            return this._dm;
         }
      }

      private void createDockManagerBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         // Create and dock a panel to the top edge. 
         DockPanel panelTop = this.dm.AddPanel( DockingStyle.Top );
         panelTop.Text = "#Top";
         DockPanel panelBottom = this.dm.AddPanel( DockingStyle.Bottom );
         panelBottom.Text = "#Bottom";
         DockPanel panelRight = this.dm.AddPanel( DockingStyle.Right );
         panelRight.Text = "#Right";
         DockPanel panelLeft = this.dm.AddPanel( DockingStyle.Left );
         panelLeft.Text = "#Left";
         DockPanel panelFloat = this.dm.AddPanel( DockingStyle.Float );
         panelFloat.Text = "Float #1";
      }

      private void clearDockManagerBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         if( this._dm != null )
         {
            this._dm.Clear( );
         }
      }

      private void destroyDockManagerbarButtonItem1_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         if( this._dm != null )
         {
            this._dm.Dispose( );
            this._dm = null;
         }
      }

      private void dockPanelToLeftPanelBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         // Create a panel and dock it to the form's right edge. 
         DockPanel panel1 = this.dm.AddPanel( DockingStyle.Right );
         panel1.Text = "Panel 1";
         // Add a new panel to panel1. This forms a split container that owns panel1 and panel2. 
         DockPanel panel2 = panel1.AddPanel( );
         panel2.Text = "Panel 2";
         // Transform the split container into a tab container. 
         DockPanel container = panel1.ParentPanel;
         container.Tabbed = true;
      }

      private void addControlsToPanelbarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         // Create dock panels, panel1 and panel2 form a split container. 
         DockPanel panel1 = this.dm.AddPanel( DockingStyle.Top );
         panel1.Text = "Panel 1";
         DockPanel panel2 = panel1.AddPanel( );
         panel2.Text = "Panel 2";

         // Place a PropertyGrid control on panel1. 
         PropertyGrid pGrid = new PropertyGrid( );
         pGrid.SelectedObject = panel1;
         pGrid.Dock = DockStyle.Fill;
         panel1.ControlContainer.Controls.Add( pGrid );

         // Place a ListBox control on panel2. 
         ListBox lBox = new ListBox( );
         lBox.Items.AddRange( new string[ ] { "Item 1", "Item 2", "Item 3" } );
         lBox.Dock = DockStyle.Fill;
         panel2.ControlContainer.Controls.Add( lBox );
      }

      private void removeActiveBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.dm.RemovePanel( this.dm.ActivePanel );
      }

      private void hideFloatingPlanelsBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         bool isToHide = string.Compare( this.hideFloatingPlanelsBarButtonItem.Caption, "Hide Floating Panels", StringComparison.Ordinal ) == 0;
         if( isToHide )
         {
            int index = 0;
            // Iterate through the visible panels which are not owned by other panels. 
            while( index < this.dm.RootPanels.Count )
            {
               DockPanel panel = this.dm.RootPanels[ index ];
               // Hide the panel if it's floating. 
               if( panel.FloatForm == null )
                  index++;
               else
                  panel.Hide( );
            }
            this.hideFloatingPlanelsBarButtonItem.Caption = "Show Floating Panels";
         }
         else
         {
            int count = this.dm.AutoHideContainers.Count;
            // Iterate through the visible panels which are not owned by other panels. 
            while( this.dm.HiddenPanels.Count > 0 )
            {
               DockPanel panel = this.dm.HiddenPanels[ 0 ];
               panel.Show( );
               //switch( panel.Visibility )
               //{
               //   case DockVisibility.Visible:
               //      break;
               //   case DockVisibility.Hidden:
               //      break;
               //   case DockVisibility.AutoHide:
               //      break;
               //   default:
               //      break;
               //}
            }
            this.hideFloatingPlanelsBarButtonItem.Caption = "Hide Floating Panels";
         }
      }

      private void DockAsSplitToBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         //// create a tab container with panel1 and panel2 tabs 
         //panel2.DockAsTab( panel1, 1 );

         ////or 

         //// create a split container with two panels 
         //panel2.DockTo( panel1 );
         //// transform a split container into a tab container 
         //panel1.ParentPanel.Tabbed = true;
      }

      private void showAutoHiddenPanelsBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         showTopAutoHiddenDockPanels( );
         showLeftAutoHiddenDockPanels( );
         showBottomAutoHiddenDockPanels( );
         showRightAutoHiddenDockPanels( );
         showFloatAutoHiddenDockPanels( );
         showFillAutoHiddenDockPanels( );
      }
      private void showTopAutoHiddenDockPanels()
      {
         AutoHideContainer container = this.dm.AutoHideContainers[ DockingStyle.Top ];
         makeVisible( container );
      }
      private void showLeftAutoHiddenDockPanels()
      {
         AutoHideContainer container = this.dm.AutoHideContainers[ DockingStyle.Left ];
         makeVisible( container );
      }
      private void showBottomAutoHiddenDockPanels()
      {
         AutoHideContainer container = this.dm.AutoHideContainers[ DockingStyle.Bottom ];
         makeVisible( container );
      }
      private void showRightAutoHiddenDockPanels()
      {
         AutoHideContainer container = this.dm.AutoHideContainers[ DockingStyle.Right ];
         makeVisible( container );
      }
      private void showFloatAutoHiddenDockPanels()
      {
         AutoHideContainer container = this.dm.AutoHideContainers[ DockingStyle.Float ];
         makeVisible( container );
      }
      private void showFillAutoHiddenDockPanels()
      {
         AutoHideContainer container = this.dm.AutoHideContainers[ DockingStyle.Fill ];
         makeVisible( container );
      }

      private static void makeVisible( AutoHideContainer container )
      {
         if( container != null )
         {
            while( container.Count > 0 )
            {
               DockPanel dp = container[ container.Count - 1 ];
               dp.Visibility = DockVisibility.Visible;
            }
         }
      }
      private static void makeHidden( AutoHideContainer container )
      {
         if( container != null )
         {
            while( container.Count > 0 )
            {
               DockPanel dp = container[ container.Count - 1 ];
               dp.Visibility = DockVisibility.Hidden;
            }
         }
      }
      private static void makeAutoHide( AutoHideContainer container )
      {
         if( container != null )
         {
            while( container.Count > 0 )
            {
               DockPanel dp = container[ container.Count - 1 ];
               dp.Visibility = DockVisibility.AutoHide;
            }
         }
      }

      private void hideAutoHiddenPanelsBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }
   }
}
