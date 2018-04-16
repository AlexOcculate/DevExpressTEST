namespace DockManagerTest
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if( disposing && (components != null) )
         {
            components.Dispose( );
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.createDockManagerBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.dockManagerBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.skinsBarSubItem = new DevExpress.XtraBars.SkinBarSubItem();
         this.destroyDockManagerbarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.dockPanelToLeftPanelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.addControlsToPanelbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.clearDockManagerBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.removeActiveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.hideFloatingPlanelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.dockingPanelsBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.dockAsTabBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.DockAsSplitToBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.showAutoHiddenPanelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
         this.hideAutoHiddenPanelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         this.SuspendLayout();
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.createDockManagerBarButtonItem,
            this.dockManagerBarSubItem,
            this.skinsBarSubItem,
            this.destroyDockManagerbarButtonItem1,
            this.dockPanelToLeftPanelBarButtonItem,
            this.addControlsToPanelbarButtonItem,
            this.clearDockManagerBarButtonItem,
            this.removeActiveBarButtonItem,
            this.hideFloatingPlanelsBarButtonItem,
            this.barButtonItem1,
            this.dockingPanelsBarSubItem,
            this.dockAsTabBarButtonItem,
            this.DockAsSplitToBarButtonItem,
            this.showAutoHiddenPanelsBarButtonItem,
            this.barSubItem1,
            this.hideAutoHiddenPanelsBarButtonItem});
         this.barManager1.MainMenu = this.bar2;
         this.barManager1.MaxItemId = 16;
         this.barManager1.StatusBar = this.bar3;
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 1;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.dockManagerBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.dockingPanelsBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinsBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
         this.bar1.Text = "Tools";
         // 
         // bar2
         // 
         this.bar2.BarName = "Main menu";
         this.bar2.DockCol = 0;
         this.bar2.DockRow = 0;
         this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // bar3
         // 
         this.bar3.BarName = "Status bar";
         this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         this.bar3.DockCol = 0;
         this.bar3.DockRow = 0;
         this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         this.bar3.OptionsBar.AllowQuickCustomization = false;
         this.bar3.OptionsBar.DrawDragBorder = false;
         this.bar3.OptionsBar.UseWholeRow = true;
         this.bar3.Text = "Status bar";
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.barDockControlTop.Size = new System.Drawing.Size(1065, 62);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 726);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.barDockControlBottom.Size = new System.Drawing.Size(1065, 18);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 664);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(1065, 62);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.barDockControlRight.Size = new System.Drawing.Size(0, 664);
         // 
         // createDockManagerBarButtonItem
         // 
         this.createDockManagerBarButtonItem.Caption = "Create DockManager";
         this.createDockManagerBarButtonItem.Id = 0;
         this.createDockManagerBarButtonItem.Name = "createDockManagerBarButtonItem";
         this.createDockManagerBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.createDockManagerBarButtonItem_ItemClick);
         // 
         // dockManagerBarSubItem
         // 
         this.dockManagerBarSubItem.Caption = "DockManager";
         this.dockManagerBarSubItem.Id = 1;
         this.dockManagerBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.createDockManagerBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.clearDockManagerBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.destroyDockManagerbarButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addControlsToPanelbarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeActiveBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.hideFloatingPlanelsBarButtonItem, true)});
         this.dockManagerBarSubItem.Name = "dockManagerBarSubItem";
         // 
         // skinsBarSubItem
         // 
         this.skinsBarSubItem.Caption = "Skins && Themes";
         this.skinsBarSubItem.Id = 2;
         this.skinsBarSubItem.Name = "skinsBarSubItem";
         // 
         // destroyDockManagerbarButtonItem1
         // 
         this.destroyDockManagerbarButtonItem1.Caption = "Destroy DockManager";
         this.destroyDockManagerbarButtonItem1.Id = 3;
         this.destroyDockManagerbarButtonItem1.Name = "destroyDockManagerbarButtonItem1";
         this.destroyDockManagerbarButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.destroyDockManagerbarButtonItem1_ItemClick);
         // 
         // dockPanelToLeftPanelBarButtonItem
         // 
         this.dockPanelToLeftPanelBarButtonItem.Caption = "Dock Panel To Left Panel";
         this.dockPanelToLeftPanelBarButtonItem.Id = 4;
         this.dockPanelToLeftPanelBarButtonItem.Name = "dockPanelToLeftPanelBarButtonItem";
         this.dockPanelToLeftPanelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dockPanelToLeftPanelBarButtonItem_ItemClick);
         // 
         // addControlsToPanelbarButtonItem
         // 
         this.addControlsToPanelbarButtonItem.Caption = "Add Controls To Panel";
         this.addControlsToPanelbarButtonItem.Id = 5;
         this.addControlsToPanelbarButtonItem.Name = "addControlsToPanelbarButtonItem";
         this.addControlsToPanelbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addControlsToPanelbarButtonItem_ItemClick);
         // 
         // clearDockManagerBarButtonItem
         // 
         this.clearDockManagerBarButtonItem.Caption = "Clear DockManager";
         this.clearDockManagerBarButtonItem.Id = 6;
         this.clearDockManagerBarButtonItem.Name = "clearDockManagerBarButtonItem";
         this.clearDockManagerBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearDockManagerBarButtonItem_ItemClick);
         // 
         // removeActiveBarButtonItem
         // 
         this.removeActiveBarButtonItem.Caption = "Remove Active Panel";
         this.removeActiveBarButtonItem.Id = 7;
         this.removeActiveBarButtonItem.Name = "removeActiveBarButtonItem";
         this.removeActiveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.removeActiveBarButtonItem_ItemClick);
         // 
         // hideFloatingPlanelsBarButtonItem
         // 
         this.hideFloatingPlanelsBarButtonItem.Caption = "Hide Floating Panels";
         this.hideFloatingPlanelsBarButtonItem.Id = 8;
         this.hideFloatingPlanelsBarButtonItem.Name = "hideFloatingPlanelsBarButtonItem";
         this.hideFloatingPlanelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hideFloatingPlanelsBarButtonItem_ItemClick);
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "barButtonItem1";
         this.barButtonItem1.Id = 9;
         this.barButtonItem1.Name = "barButtonItem1";
         // 
         // dockingPanelsBarSubItem
         // 
         this.dockingPanelsBarSubItem.Caption = "Dock Panels";
         this.dockingPanelsBarSubItem.Id = 10;
         this.dockingPanelsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.dockPanelToLeftPanelBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.dockAsTabBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.DockAsSplitToBarButtonItem)});
         this.dockingPanelsBarSubItem.Name = "dockingPanelsBarSubItem";
         // 
         // dockAsTabBarButtonItem
         // 
         this.dockAsTabBarButtonItem.Caption = "Dock As Tab";
         this.dockAsTabBarButtonItem.Id = 11;
         this.dockAsTabBarButtonItem.Name = "dockAsTabBarButtonItem";
         // 
         // DockAsSplitToBarButtonItem
         // 
         this.DockAsSplitToBarButtonItem.Caption = "Dock To (as Split)";
         this.DockAsSplitToBarButtonItem.Id = 12;
         this.DockAsSplitToBarButtonItem.Name = "DockAsSplitToBarButtonItem";
         this.DockAsSplitToBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DockAsSplitToBarButtonItem_ItemClick);
         // 
         // showAutoHiddenPanelsBarButtonItem
         // 
         this.showAutoHiddenPanelsBarButtonItem.Caption = "Show Panels";
         this.showAutoHiddenPanelsBarButtonItem.Id = 13;
         this.showAutoHiddenPanelsBarButtonItem.Name = "showAutoHiddenPanelsBarButtonItem";
         this.showAutoHiddenPanelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showAutoHiddenPanelsBarButtonItem_ItemClick);
         // 
         // barSubItem1
         // 
         this.barSubItem1.Caption = "Auto Hidden Panels";
         this.barSubItem1.Id = 14;
         this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.showAutoHiddenPanelsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.hideAutoHiddenPanelsBarButtonItem)});
         this.barSubItem1.Name = "barSubItem1";
         // 
         // hideAutoHiddenPanelsBarButtonItem
         // 
         this.hideAutoHiddenPanelsBarButtonItem.Caption = "Hide Panels";
         this.hideAutoHiddenPanelsBarButtonItem.Id = 15;
         this.hideAutoHiddenPanelsBarButtonItem.Name = "hideAutoHiddenPanelsBarButtonItem";
         this.hideAutoHiddenPanelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hideAutoHiddenPanelsBarButtonItem_ItemClick);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1065, 744);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem createDockManagerBarButtonItem;
      private DevExpress.XtraBars.BarSubItem dockManagerBarSubItem;
      private DevExpress.XtraBars.SkinBarSubItem skinsBarSubItem;
      private DevExpress.XtraBars.BarButtonItem destroyDockManagerbarButtonItem1;
      private DevExpress.XtraBars.BarButtonItem dockPanelToLeftPanelBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem addControlsToPanelbarButtonItem;
      private DevExpress.XtraBars.BarButtonItem clearDockManagerBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem removeActiveBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem hideFloatingPlanelsBarButtonItem;
      private DevExpress.XtraBars.BarSubItem dockingPanelsBarSubItem;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
      private DevExpress.XtraBars.BarButtonItem dockAsTabBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem DockAsSplitToBarButtonItem;
      private DevExpress.XtraBars.BarSubItem barSubItem1;
      private DevExpress.XtraBars.BarButtonItem showAutoHiddenPanelsBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem hideAutoHiddenPanelsBarButtonItem;
   }
}

