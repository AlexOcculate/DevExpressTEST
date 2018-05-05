using DevExpress.XtraCharts;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GridCardAndLayoutView
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         this.InitializeComponent();
         {
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowPreview = true;
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
         }
         this.CustomDrawEmptyForeground();
         //{
         //   this.dataTable = MetadataItem.CreateMetadataItemTable( );
         //   this.gridControl1.DataSource = this.dataTable;
         //   GridColumnCollection columns = this.gridView1.Columns;
         //   foreach( GridColumn gc in columns )
         //   {
         //      string fieldName = gc.FieldName;
         //      string name = gc.Name;
         //      gc.Visible = MetadataItem.IsFieldVisibleByDefault( fieldName );
         //   }
         //}
         {
            this.masterTable = CreateMasterTable();
            CreateMaterDataValues( this.masterTable );
            this.detailTable = CreateDetailTable( );
            CreateDetailDataValues( this.detailTable );
            this.gridControl1.DataSource = this.masterTable;
            GridColumn gc = new GridColumn()
            {
               Caption = "Custom Unbound Chart",
               FieldName = "Chart",
              // UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.CreateChartEdit(gc, this.chartControl1222);
            this.cardView1.Columns.Add(gc);
            this.cardView1.CustomUnboundColumnData += (sender, e) =>
            {
               if(e.Column.FieldName == "Chart")
               {
                  // Populate columns 
                  if(e.IsGetData)
                  {
                     e.Value = this.GetChartData(e.Row);
                  }
                  return;
               }
               if(e.Column.FieldName == "Other")
               {
                  // Populate columns 
                  if(e.IsGetData)
                  {
                     if(this.unboundData.ContainsKey(e.ListSourceRowIndex))
                     {
                        e.Value = this.unboundData[ e.ListSourceRowIndex ];
                     }
                     else
                     {
                     }
                  }
                  // Post edits back to the source 
                  if(e.IsSetData && e.Value != null)
                  {
                     this.unboundData[e.ListSourceRowIndex] = e.Value.ToString();
                  }
                  return;
               }
            };
         }
      }

      private DataTable masterTable, detailTable;
      private DevExpress.XtraCharts.ChartControl chartControl1222 = new ChartControl();
      // Handling the CustomUnboundColumnData event 
      private Dictionary<int, string> unboundData = new Dictionary<int, string>();
      private Dictionary<int, List<EmployeeSalesByCategoryChartData>> chartData = new Dictionary<int, List<EmployeeSalesByCategoryChartData>>();

      private void CreateChartEdit(GridColumn column, ChartControl chartControl)
      {
         if(column.ColumnEdit != null)
         {
            return;
         }

         RepositoryItemAnyControl item = new RepositoryItemAnyControl();
         item.Control = chartControl;
         //column.View.GridControl.RepositoryItems.Add( item );
         this.gridControl1.RepositoryItems.Add(item);
         //((GridView) column.View).OptionsSelection.EnableAppearanceHideSelection = false;
         column.OptionsColumn.AllowEdit = false;
         column.OptionsFilter.AllowFilter = false;
         column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
         column.ColumnEdit = item;
      }

      private object GetChartData(object val)
      {
         DataRowView row = val as DataRowView;
         if(row == null)
         {
            return null;
         }

         int key = (int) row["ID"];
         if(!this.chartData.ContainsKey(key))
         {
            this.chartData.Add( key, this.GetEmployeeSalesByCategoryChartData( key ) );
         }

         return this.chartData[key];
      }

      private List<EmployeeSalesByCategoryChartData> GetEmployeeSalesByCategoryChartData(int key)
      {
         List<EmployeeSalesByCategoryChartData> ret = new List<EmployeeSalesByCategoryChartData>();
         foreach(DataRow row in this.detailTable.Rows)
         {
            if(key.Equals(row["ID"]))
            {
               ret.Add( new EmployeeSalesByCategoryChartData( )
               {
                  CategoryName = row[ "CategoryName" ].ToString( ),
                  Quantity = (double) row[ "SumOfQuantity" ]
               }
              );
            }
         }
         return ret;
      }

      public class EmployeeSalesByCategoryChartData
      {
         public string CategoryName
         {
            get; set;
         }

         public double Quantity
         {
            get; set;
         }
      }

      private void CustomDrawEmptyForeground()
      {
         string searchName = string.Empty;
         // gridView.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator( "Category_Name", searchName );

         // Initialize variables used to paint View's empty space in a custom manner 
         System.Drawing.Font noMatchesFoundTextFont = new System.Drawing.Font("Tahoma", 10);
         System.Drawing.Font trySearchingAgainTextFont = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Underline);
         System.Drawing.Font trySearchingAgainTextFontBold = new System.Drawing.Font(trySearchingAgainTextFont, System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold);
         System.Drawing.SolidBrush linkBrush = new System.Drawing.SolidBrush(DevExpress.Skins.EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel)
            .Colors["HyperLinkTextColor"]);
         string noMatchesFoundText = "No matches found";
         string trySearchingAgainText = "Try searching again";
         System.Drawing.Rectangle noMatchesFoundBounds = System.Drawing.Rectangle.Empty;
         System.Drawing.Rectangle trySearchingAgainBounds = System.Drawing.Rectangle.Empty;
         bool trySearchingAgainBoundsContainCursor = false;
         int offset = 10;

         //Handle this event to paint View's empty space in a custom manner 
         this.gridView1.CustomDrawEmptyForeground += (s, e) =>
         {
            e.DefaultDraw();
            e.Appearance.Options.UseFont = true;
            e.Appearance.Font = noMatchesFoundTextFont;
            //Draw the noMatchesFoundText string 
            System.Drawing.Size size = e.Appearance.CalcTextSize(e.Cache, noMatchesFoundText, e.Bounds.Width).ToSize();
            int x = (e.Bounds.Width - size.Width) / 2;
            int y = e.Bounds.Y + offset;
            noMatchesFoundBounds = new System.Drawing.Rectangle(new System.Drawing.Point(x, y), size);
            e.Appearance.DrawString(e.Cache, noMatchesFoundText, noMatchesFoundBounds);
            //Draw the trySearchingAgain link 
            e.Appearance.Font = trySearchingAgainBoundsContainCursor
               ? trySearchingAgainTextFontBold
               : trySearchingAgainTextFont;
            size = e.Appearance.CalcTextSize(e.Cache, trySearchingAgainText, e.Bounds.Width).ToSize();
            x = noMatchesFoundBounds.X - (size.Width - noMatchesFoundBounds.Width) / 2;
            y = noMatchesFoundBounds.Bottom + offset;
            size.Width += offset;
            trySearchingAgainBounds = new System.Drawing.Rectangle(new System.Drawing.Point(x, y), size);
            e.Appearance.DrawString(e.Cache, trySearchingAgainText, trySearchingAgainBounds, linkBrush);
         };

         this.gridView1.MouseMove += (s, e) =>
         {
            trySearchingAgainBoundsContainCursor = trySearchingAgainBounds.Contains(e.Location);
            this.gridControl1.Cursor = trySearchingAgainBoundsContainCursor
               ? System.Windows.Forms.Cursors.Hand
               : System.Windows.Forms.Cursors.Default;
            this.gridView1.InvalidateRect(trySearchingAgainBounds);
         };

         this.gridView1.MouseDown += (s, e) =>
         {
            if(trySearchingAgainBoundsContainCursor)
            {
               searchName = DevExpress.XtraEditors.XtraInputBox.Show($"Enter {nameof( Name )}", $"Enter {nameof( Name )} dialog", searchName);
               // gridView.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator( "Category_Name", searchName );
            }
         };
      }

      public static System.Data.DataTable CreateMasterTable(string name = "XPTO")
      {
         System.Data.DataTable t = new System.Data.DataTable(name);
         {
            System.Data.DataColumn c = new System.Data.DataColumn();
            c.DataType = typeof(int);
            c.ColumnName = "ID";
            c.ReadOnly = true;
            c.Unique = false;
            t.Columns.Add(c);
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn();
            c.DataType = typeof(string);
            c.ColumnName = "NAME";
            c.ReadOnly = true;
            t.Columns.Add(c);
         }
         return t;
      }
      public static System.Data.DataTable CreateDetailTable( string name = "XPTO" )
      {
         System.Data.DataTable t = new System.Data.DataTable( name );
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = "ID";
            c.ReadOnly = true;
            c.Unique = false;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "CategoryName";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( double );
            c.ColumnName = "SumOfQuantity";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         return t;
      }

      public static void CreateMaterDataValues(DataTable t)
      {
         {
            DataRow r = t.NewRow();
            r["ID"] = 100;
            r["NAME"] = "Lalal da Silva";
            t.Rows.Add(r);
         }
      }
      public static void CreateDetailDataValues( DataTable t )
      {
         {
            DataRow r = t.NewRow( );
            r[ "ID" ] = 100;
            r[ "CategoryName" ] = "sch";
            r[ "SumOfQuantity" ] = 10.0;
            t.Rows.Add( r );
         }
         {
            DataRow r = t.NewRow( );
            r[ "ID" ] = 100;
            r[ "CategoryName" ] = "tbl";
            r[ "SumOfQuantity" ] = 100.0;
            t.Rows.Add( r );
         }
         {
            DataRow r = t.NewRow( );
            r[ "ID" ] = 100;
            r[ "CategoryName" ] = "vw";
            r[ "SumOfQuantity" ] = 50.0;
            t.Rows.Add( r );
         }
      }
   }
}
