namespace Prop
{
   partial class PropXtraUserControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropXtraUserControl));
         this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
         this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
         this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.categoryBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.alphabeticBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.expandBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.collapseBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.propertyDescriptionControl1 = new DevExpress.XtraVerticalGrid.PropertyDescriptionControl();
         this.enabledSvgImageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.enabledSvgImageCollection)).BeginInit();
         this.SuspendLayout();
         // 
         // comboBoxEdit1
         // 
         this.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Top;
         this.comboBoxEdit1.Location = new System.Drawing.Point(0, 0);
         this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(2);
         this.comboBoxEdit1.Name = "comboBoxEdit1";
         this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.comboBoxEdit1.Size = new System.Drawing.Size(595, 20);
         this.comboBoxEdit1.TabIndex = 0;
         // 
         // searchControl1
         // 
         this.searchControl1.Client = this.propertyGridControl;
         this.searchControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.searchControl1.Location = new System.Drawing.Point(0, 20);
         this.searchControl1.Margin = new System.Windows.Forms.Padding(2);
         this.searchControl1.Name = "searchControl1";
         this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton(),
            new DevExpress.XtraEditors.Repository.MRUButton()});
         this.searchControl1.Properties.Client = this.propertyGridControl;
         this.searchControl1.Properties.ShowMRUButton = true;
         this.searchControl1.Size = new System.Drawing.Size(595, 20);
         this.searchControl1.TabIndex = 1;
         // 
         // propertyGridControl
         // 
         this.propertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.propertyGridControl.Location = new System.Drawing.Point(0, 65);
         this.propertyGridControl.Margin = new System.Windows.Forms.Padding(2);
         this.propertyGridControl.Name = "propertyGridControl";
         this.propertyGridControl.OptionsFind.FindFilterColumns = "Caption";
         this.propertyGridControl.OptionsFind.ShowCloseButton = false;
         this.propertyGridControl.OptionsFind.Visibility = DevExpress.XtraVerticalGrid.FindPanelVisibility.Never;
         this.propertyGridControl.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
         this.propertyGridControl.Size = new System.Drawing.Size(595, 542);
         this.propertyGridControl.TabIndex = 7;
         this.propertyGridControl.FocusedRowChanged += new DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventHandler(this.propertyGridControl_FocusedRowChanged);
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.alphabeticBarButtonItem,
            this.expandBarButtonItem,
            this.collapseBarButtonItem,
            this.categoryBarButtonItem});
         this.barManager1.MaxItemId = 4;
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 0;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
         this.bar1.FloatLocation = new System.Drawing.Point(558, 287);
         this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.categoryBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.alphabeticBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.expandBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.collapseBarButtonItem)});
         this.bar1.OptionsBar.DisableClose = true;
         this.bar1.OptionsBar.DrawBorder = false;
         this.bar1.OptionsBar.DrawDragBorder = false;
         this.bar1.OptionsBar.DrawSizeGrip = true;
         this.bar1.OptionsBar.UseWholeRow = true;
         this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
         this.bar1.Text = "Tools";
         // 
         // categoryBarButtonItem
         // 
         this.categoryBarButtonItem.Caption = "Category";
         this.categoryBarButtonItem.Enabled = false;
         this.categoryBarButtonItem.Id = 3;
         this.categoryBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("categoryBarButtonItem.ImageOptions.SvgImage")));
         this.categoryBarButtonItem.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
         this.categoryBarButtonItem.Name = "categoryBarButtonItem";
         this.categoryBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.categoryBarButtonItem_ItemClick);
         // 
         // alphabeticBarButtonItem
         // 
         this.alphabeticBarButtonItem.Caption = "Alphabetic";
         this.alphabeticBarButtonItem.Id = 0;
         this.alphabeticBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("alphabeticBarButtonItem.ImageOptions.SvgImage")));
         this.alphabeticBarButtonItem.Name = "alphabeticBarButtonItem";
         this.alphabeticBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.alphabeticBarButtonItem_ItemClick);
         // 
         // expandBarButtonItem
         // 
         this.expandBarButtonItem.Caption = "Expand";
         this.expandBarButtonItem.Id = 1;
         this.expandBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("expandBarButtonItem.ImageOptions.SvgImage")));
         this.expandBarButtonItem.Name = "expandBarButtonItem";
         this.expandBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.expandBarButtonItem_ItemClick);
         // 
         // collapseBarButtonItem
         // 
         this.collapseBarButtonItem.Caption = "Collapse";
         this.collapseBarButtonItem.Id = 2;
         this.collapseBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("collapseBarButtonItem.ImageOptions.SvgImage")));
         this.collapseBarButtonItem.Name = "collapseBarButtonItem";
         this.collapseBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.collapseBarButtonItem_ItemClick);
         // 
         // standaloneBarDockControl1
         // 
         this.standaloneBarDockControl1.CausesValidation = false;
         this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 40);
         this.standaloneBarDockControl1.Manager = this.barManager1;
         this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(2);
         this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
         this.standaloneBarDockControl1.Size = new System.Drawing.Size(595, 25);
         this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControlTop.Size = new System.Drawing.Size(595, 0);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 607);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControlBottom.Size = new System.Drawing.Size(595, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 607);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(595, 0);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControlRight.Size = new System.Drawing.Size(0, 607);
         // 
         // propertyDescriptionControl1
         // 
         this.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.propertyDescriptionControl1.Location = new System.Drawing.Point(0, 507);
         this.propertyDescriptionControl1.Name = "propertyDescriptionControl1";
         this.propertyDescriptionControl1.PropertyGrid = this.propertyGridControl;
         this.propertyDescriptionControl1.Size = new System.Drawing.Size(595, 100);
         this.propertyDescriptionControl1.TabIndex = 13;
         this.propertyDescriptionControl1.TabStop = false;
         // 
         // enabledSvgImageCollection
         // 
         this.enabledSvgImageCollection.Add("Category", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("enabledSvgImageCollection.Category"))));
         // 
         // PropXtraUserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.propertyDescriptionControl1);
         this.Controls.Add(this.propertyGridControl);
         this.Controls.Add(this.standaloneBarDockControl1);
         this.Controls.Add(this.searchControl1);
         this.Controls.Add(this.comboBoxEdit1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Margin = new System.Windows.Forms.Padding(2);
         this.Name = "PropXtraUserControl";
         this.Size = new System.Drawing.Size(595, 607);
         ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.enabledSvgImageCollection)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
      private DevExpress.XtraEditors.SearchControl searchControl1;
      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem alphabeticBarButtonItem;
      private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
      private DevExpress.XtraBars.BarButtonItem expandBarButtonItem;
      private DevExpress.XtraVerticalGrid.PropertyDescriptionControl propertyDescriptionControl1;
      private DevExpress.XtraBars.BarButtonItem collapseBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem categoryBarButtonItem;
      private DevExpress.Utils.SvgImageCollection enabledSvgImageCollection;
   }
}
