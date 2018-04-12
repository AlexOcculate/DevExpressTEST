namespace GridXtraUserControl
{
   partial class SysCSXtraUserControl
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysCSXtraUserControl));
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.showAllFieldsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.sysConnectionStringBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colIsSys = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colProviderName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colConnectionString = new DevExpress.XtraGrid.Columns.GridColumn();
         this.showPreviewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sysConnectionStringBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         this.SuspendLayout();
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
            this.refreshBarButtonItem,
            this.showAllFieldsBarButtonItem,
            this.showPreviewBarButtonItem});
         this.barManager1.MaxItemId = 3;
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 0;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
         this.bar1.FloatLocation = new System.Drawing.Point(602, 234);
         this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.showAllFieldsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.showPreviewBarButtonItem)});
         this.bar1.OptionsBar.DisableClose = true;
         this.bar1.OptionsBar.DrawBorder = false;
         this.bar1.OptionsBar.DrawDragBorder = false;
         this.bar1.OptionsBar.UseWholeRow = true;
         this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
         this.bar1.Text = "Tools";
         // 
         // refreshBarButtonItem
         // 
         this.refreshBarButtonItem.Caption = "Refresh";
         this.refreshBarButtonItem.Id = 0;
         this.refreshBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("refreshBarButtonItem.ImageOptions.SvgImage")));
         this.refreshBarButtonItem.Name = "refreshBarButtonItem";
         this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
         // 
         // showAllFieldsBarButtonItem
         // 
         this.showAllFieldsBarButtonItem.Caption = "Show All Fields";
         this.showAllFieldsBarButtonItem.Id = 1;
         this.showAllFieldsBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showAllFieldsBarButtonItem.ImageOptions.SvgImage")));
         this.showAllFieldsBarButtonItem.Name = "showAllFieldsBarButtonItem";
         this.showAllFieldsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showAllFieldsBarButtonItem_ItemClick);
         // 
         // standaloneBarDockControl1
         // 
         this.standaloneBarDockControl1.CausesValidation = false;
         this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
         this.standaloneBarDockControl1.Manager = this.barManager1;
         this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
         this.standaloneBarDockControl1.Size = new System.Drawing.Size(806, 43);
         this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(806, 0);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 706);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(806, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 706);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(806, 0);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 706);
         // 
         // gridControl1
         // 
         this.gridControl1.DataSource = this.sysConnectionStringBindingSource;
         this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControl1.Location = new System.Drawing.Point(0, 43);
         this.gridControl1.MainView = this.gridView1;
         this.gridControl1.MenuManager = this.barManager1;
         this.gridControl1.Name = "gridControl1";
         this.gridControl1.Size = new System.Drawing.Size(806, 663);
         this.gridControl1.TabIndex = 5;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
         // 
         // sysConnectionStringBindingSource
         // 
         this.sysConnectionStringBindingSource.DataSource = typeof(GridXtraUserControl.SysConnectionString);
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSys,
            this.colName,
            this.colProviderName,
            this.colConnectionString});
         this.gridView1.GridControl = this.gridControl1;
         this.gridView1.Name = "gridView1";
         this.gridView1.OptionsBehavior.ReadOnly = true;
         this.gridView1.OptionsFind.AlwaysVisible = true;
         this.gridView1.OptionsView.ShowAutoFilterRow = true;
         this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
         this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
         // 
         // colIsSys
         // 
         this.colIsSys.FieldName = "IsSys";
         this.colIsSys.Name = "colIsSys";
         // 
         // colName
         // 
         this.colName.FieldName = "Name";
         this.colName.Name = "colName";
         this.colName.Visible = true;
         this.colName.VisibleIndex = 0;
         // 
         // colProviderName
         // 
         this.colProviderName.FieldName = "ProviderName";
         this.colProviderName.Name = "colProviderName";
         // 
         // colConnectionString
         // 
         this.colConnectionString.FieldName = "ConnectionString";
         this.colConnectionString.Name = "colConnectionString";
         // 
         // showPreviewBarButtonItem
         // 
         this.showPreviewBarButtonItem.Caption = "Show Preview";
         this.showPreviewBarButtonItem.Id = 2;
         this.showPreviewBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
         this.showPreviewBarButtonItem.Name = "showPreviewBarButtonItem";
         this.showPreviewBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showPreviewBarButtonItem_ItemClick);
         // 
         // SysCSXtraUserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.gridControl1);
         this.Controls.Add(this.standaloneBarDockControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "SysCSXtraUserControl";
         this.Size = new System.Drawing.Size(806, 706);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sysConnectionStringBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
      private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private System.Windows.Forms.BindingSource sysConnectionStringBindingSource;
      private DevExpress.XtraGrid.Columns.GridColumn colIsSys;
      private DevExpress.XtraGrid.Columns.GridColumn colName;
      private DevExpress.XtraGrid.Columns.GridColumn colProviderName;
      private DevExpress.XtraGrid.Columns.GridColumn colConnectionString;
      private DevExpress.XtraBars.BarButtonItem showAllFieldsBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem showPreviewBarButtonItem;
   }
}
