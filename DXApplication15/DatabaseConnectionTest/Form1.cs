using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseConnectionTest
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         InitializeComponent( );
      }

      private void testSqliteConnectionBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder(
            @"Data Source=C:\TMP\Sqlite\mydb.db;Version=3;Password=myPassword;" );
         builder.BaseSchemaName = "saschama";
         //builder.DataSource = "_ds_";
         //builder.Password = "sa";
         //
         string str = builder.ToString( );
         ICollection keys = builder.Keys;
         ICollection values = builder.Values;

         

         using( SQLiteConnection conn = new SQLiteConnection( builder.ConnectionString ) )
    {
            conn.Open( );
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand( sql, conn );
            command.ExecuteNonQuery( );
         }
      }
   }
}
