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
         this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
         this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
         this.sortOrderBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
         this.propertyDescriptionControl1 = new DevExpress.XtraVerticalGrid.PropertyDescriptionControl();
         this.expandBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
         this.SuspendLayout();
         // 
         // comboBoxEdit1
         // 
         this.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Top;
         this.comboBoxEdit1.Location = new System.Drawing.Point(0, 0);
         this.comboBoxEdit1.Name = "comboBoxEdit1";
         this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.comboBoxEdit1.Size = new System.Drawing.Size(892, 26);
         this.comboBoxEdit1.TabIndex = 0;
         // 
         // searchControl1
         // 
         this.searchControl1.Client = this.propertyGridControl1;
         this.searchControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.searchControl1.Location = new System.Drawing.Point(0, 26);
         this.searchControl1.Name = "searchControl1";
         this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton(),
            new DevExpress.XtraEditors.Repository.MRUButton()});
         this.searchControl1.Properties.Client = this.propertyGridControl1;
         this.searchControl1.Properties.ShowMRUButton = true;
         this.searchControl1.Size = new System.Drawing.Size(892, 26);
         this.searchControl1.TabIndex = 1;
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.sortOrderBarButtonItem,
            this.expandBarButtonItem});
         this.barManager1.MaxItemId = 2;
         this.barManager1.StatusBar = this.bar3;
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(892, 0);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 861);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(892, 26);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 861);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(892, 0);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 861);
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 0;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
         this.bar1.FloatLocation = new System.Drawing.Point(558, 287);
         this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.sortOrderBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.expandBarButtonItem)});
         this.bar1.OptionsBar.DisableClose = true;
         this.bar1.OptionsBar.DrawBorder = false;
         this.bar1.OptionsBar.DrawDragBorder = false;
         this.bar1.OptionsBar.DrawSizeGrip = true;
         this.bar1.OptionsBar.UseWholeRow = true;
         this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
         this.bar1.Text = "Tools";
         // 
         // bar3
         // 
         this.bar3.BarName = "Status bar";
         this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         this.bar3.DockCol = 0;
         this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         this.bar3.OptionsBar.AllowQuickCustomization = false;
         this.bar3.OptionsBar.DrawDragBorder = false;
         this.bar3.OptionsBar.UseWholeRow = true;
         this.bar3.Text = "Status bar";
         // 
         // standaloneBarDockControl1
         // 
         this.standaloneBarDockControl1.CausesValidation = false;
         this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 52);
         this.standaloneBarDockControl1.Manager = this.barManager1;
         this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
         this.standaloneBarDockControl1.Size = new System.Drawing.Size(892, 36);
         this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
         // 
         // sortOrderBarButtonItem
         // 
         this.sortOrderBarButtonItem.Caption = "Category";
         this.sortOrderBarButtonItem.Id = 0;
         this.sortOrderBarButtonItem.Name = "sortOrderBarButtonItem";
         this.sortOrderBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sortOrderBarButtonItem_ItemClick);
         // 
         // propertyGridControl1
         // 
         this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.propertyGridControl1.Location = new System.Drawing.Point(0, 88);
         this.propertyGridControl1.Name = "propertyGridControl1";
         this.propertyGridControl1.OptionsFind.FindFilterColumns = "Caption";
         this.propertyGridControl1.Size = new System.Drawing.Size(892, 773);
         this.propertyGridControl1.TabIndex = 7;
         // 
         // propertyDescriptionControl1
         // 
         this.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.propertyDescriptionControl1.Location = new System.Drawing.Point(0, 761);
         this.propertyDescriptionControl1.Name = "propertyDescriptionControl1";
         this.propertyDescriptionControl1.PropertyGrid = this.propertyGridControl1;
         this.propertyDescriptionControl1.Size = new System.Drawing.Size(892, 100);
         this.propertyDescriptionControl1.TabIndex = 8;
         this.propertyDescriptionControl1.TabStop = false;
         // 
         // expandBarButtonItem
         // 
         this.expandBarButtonItem.Caption = "Expand";
         this.expandBarButtonItem.Id = 1;
         this.expandBarButtonItem.Name = "expandBarButtonItem";
         this.expandBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.expandBarButtonItem_ItemClick);
         // 
         // PropXtraUserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.propertyDescriptionControl1);
         this.Controls.Add(this.propertyGridControl1);
         this.Controls.Add(this.standaloneBarDockControl1);
         this.Controls.Add(this.searchControl1);
         this.Controls.Add(this.comboBoxEdit1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "PropXtraUserControl";
         this.Size = new System.Drawing.Size(892, 887);
         ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
      private DevExpress.XtraEditors.SearchControl searchControl1;
      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem sortOrderBarButtonItem;
      private DevExpress.XtraVerticalGrid.PropertyDescriptionControl propertyDescriptionControl1;
      private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
      private DevExpress.XtraBars.BarButtonItem expandBarButtonItem;
   }
}
