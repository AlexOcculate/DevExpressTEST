using DevExpress.XtraCharts;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GridPlusChart
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         this.InitializeComponent();
      }

      private DataSet CreateDataSet()
      {
         // Master <-One---Many->> Details
         // {ID,Name} <-One--Many->> {ID,Argument,Value}
         // Detail Tables contains the Bar Chart {argument:value} set
         DataSet ds = new DataSet("FooBar");

         DataTable mt = new DataTable("Master");
         ds.Tables.Add(mt);

         mt.Columns.Add("ID", typeof(string));
         mt.Columns.Add(nameof(Name), typeof(string));

         // Add data rows to the table. 
         mt.Rows.Add(new object[ ] { "10", "M10" });
         mt.Rows.Add(new object[ ] { "20", "M20" });
         mt.Rows.Add(new object[ ] { "30", "M30" });
         mt.Rows.Add(new object[ ] { "40", "M40" });
         mt.Rows.Add(new object[ ] { "50", "M50" });
         mt.Rows.Add(new object[ ] { "60", "M60" });

         DataTable dt = new DataTable("Detail");
         ds.Tables.Add(dt);

         dt.Columns.Add("ID", typeof(string));
         dt.Columns.Add("Argument", typeof(string));
         dt.Columns.Add("Value", typeof(int));

         // Add data rows to the table. 
         dt.Rows.Add(new object[ ] { "10", "A", 10 });
         dt.Rows.Add(new object[ ] { "10", "B", 100 });
         dt.Rows.Add(new object[ ] { "10", "C", 40 });
         // "D" Missing!!!
         //
         dt.Rows.Add(new object[ ] { "20", "A", 1 });
         dt.Rows.Add(new object[ ] { "20", "B", 10 });
         dt.Rows.Add(new object[ ] { "20", "C", 140 });
         dt.Rows.Add(new object[ ] { "20", "D", 40 });
         //
         // ID=30 DOES NOT EXIST!
         //
         dt.Rows.Add(new object[ ] { "40", "A", 1 });
         dt.Rows.Add(new object[ ] { "40", "B", 10 });
         dt.Rows.Add(new object[ ] { "40", "C", 140 });
         // "D" Missing!!!
         //
         dt.Rows.Add(new object[ ] { "50", "A", 5 });
         dt.Rows.Add(new object[ ] { "50", "B", 10 });
         dt.Rows.Add(new object[ ] { "50", "C", 14 });
         dt.Rows.Add(new object[ ] { "50", "D", 40 });
         //
         // ID=60 DOES NOT EXIST!

         return ds;
      }

      private const string CU_CHART = "CUChart";
      private const string CU_STRING = "CUString";
      private DataSet _ds;
      private Dictionary<int, string> cuString = new Dictionary<int, string>();
      private Dictionary<int, List<SerieArgVal>> cuChart = new Dictionary<int, List<SerieArgVal>>();

      public class SerieArgVal
      {
         public SerieArgVal(string argument, int value)
         {
            this.Argument = argument ?? throw new ArgumentNullException(nameof(argument));
            this.Value = value;
         }

         public string Argument
         {
            get; set;
         }

         public int Value
         {
            get; set;
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         this._ds = this.CreateDataSet();
         this.gridControl1.DataSource = this._ds;
         this.gridControl1.DataMember = this._ds.Tables["Master"].TableName;
         {
            GridColumn gc = new GridColumn()
            {
               Caption = "Custom Unbound String",
               FieldName = CU_STRING,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.gridView1.Columns.Add(gc);
         }
         {
            GridColumn gc = new GridColumn()
            {
               Caption = "Custom Unbound Chart",
               FieldName = CU_CHART,
               UnboundType = DevExpress.Data.UnboundColumnType.Object,
               Visible = true
            };
            this.gridView1.Columns.Add(gc);
            {
               Series serie = new Series("Objects", ViewType.Bar);
               serie.ArgumentDataMember = "Argument";
               serie.ValueDataMembers.AddRange(new string[ ] { "Value" });
               ChartControl cc = new ChartControl();
               cc.Series.Add(serie);
               //
               RepositoryItemAnyControl item = new RepositoryItemAnyControl() { Control = cc };
               //column.View.GridControl.RepositoryItems.Add( item );
               this.gridControl1.RepositoryItems.Add(item);
               //((GridView) column.View).OptionsSelection.EnableAppearanceHideSelection = false;
               gc.OptionsColumn.AllowEdit = false;
               gc.OptionsFilter.AllowFilter = false;
               gc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
               gc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
               gc.ColumnEdit = item;
            }
         }
         this.gridView1.CustomUnboundColumnData += this.GridView1_CustomUnboundColumnData;
      }

      private void GridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
      {
         if(e.Column.FieldName == CU_STRING )
         {
            this.getCUString(e);
            return;
         }
         if(e.Column.FieldName == CU_CHART )
         {
            this.getCUGraph(e);
            return;
         }
      }

      private void getCUGraph(DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
      {
         if(e.IsGetData)
         {
            if(this.cuChart.ContainsKey(e.ListSourceRowIndex))
            {
               e.Value = this.cuChart[e.ListSourceRowIndex];
            } else
            {
               DataRowView drv = e.Row as DataRowView;
               string mid = drv["ID"].ToString();
               DataTable dt = this._ds.Tables["Detail"];
               List<SerieArgVal> list = new List<SerieArgVal>();
               foreach(DataRow dr in dt.Rows)
               {
                  string did = dr["ID"].ToString();
                  if(string.Compare(did, mid, StringComparison.Ordinal) == 0)
                  {
                     string argument = dr["Argument"].ToString();
                     int value = (int) dr["Value"];
                     list.Add(new SerieArgVal(argument, value));
                  }
               }
               this.cuChart.Add(e.ListSourceRowIndex, list);
               e.Value = list;
            }
         }
      }

      private void getCUString(DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
      {
         if(e.IsGetData)
         {
            if(this.cuString.ContainsKey(e.ListSourceRowIndex))
            {
               e.Value = this.cuString[e.ListSourceRowIndex];
            } else
            {
               DataRowView drv = e.Row as DataRowView;
               string mid = drv["ID"].ToString();
               DataTable dt = this._ds.Tables["Detail"];
               string x = null;
               foreach(DataRow dr in dt.Rows)
               {
                  string did = dr["ID"].ToString();
                  if(string.Compare(did, mid, StringComparison.Ordinal) == 0)
                  {
                     string argument = dr["Argument"].ToString();
                     string value = dr["Value"].ToString();
                     x += $" {argument}:{value}";
                  }
               }
               x = $"{{ {x} }}";
               this.cuString.Add(e.ListSourceRowIndex, x);
               e.Value = x;
            }
         }
      }
   }
}
