﻿using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;

namespace DatabaseConnectionTest
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         this.InitializeComponent();
      }

      private void testSqliteConnectionBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder(@"Data Source=D:\TEMP\SQLite\mydb.db;Version=3;Password=myPassword;");
         builder.BaseSchemaName = "saschama";
         //builder.DataSource = "_ds_";
         //builder.Password = "sa";
         //
         string str = builder.ToString();
         ICollection keys = builder.Keys;
         ICollection values = builder.Values;

         using(SQLiteConnection conn = new SQLiteConnection(builder.ConnectionString))
         {
            conn.Open();
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
         }
      }
      private void testmSqliteConnectionBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
      }

      private void testMsssConnectionBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(  );
         builder.DataSource = @"DBSRV\QWERTY";
         builder.UserID = @"DBSRV\user02";
         builder.Password = @"8a0IucJ@Nx1Qy5HfFrX0Ob3m";
         builder.UserID = @"user03";
         builder.Password = @"user03";
         builder.InitialCatalog = @"Sales";
         //
         string str = builder.ToString( );
         ICollection keys = builder.Keys;
         ICollection values = builder.Values;

         using( SqlConnection conn = new SqlConnection( builder.ConnectionString ) )
         {
            conn.Open( );
            string sql = "create table highscores (name varchar(20), score int)";
            using( SqlCommand command = new SqlCommand( sql, conn ) )
            {
               command.ExecuteNonQuery( );
            }
         }
      }
   }
}
