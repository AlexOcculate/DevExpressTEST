using DPControls.Controls.MetadataPuller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;

namespace AQBConnection_Test
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      private DataTable dataTable = MetadataPullerXtraUserControl.CreateMetadataItemTable( );
      private SQLiteConnectionStringBuilder sqliteCSBuilder = new SQLiteConnectionStringBuilder( )
      {
         DataSource = @"D:\TEMP\SQLite\mydb.db"
      };
      private SqlConnectionStringBuilder msssCSBuilder = new SqlConnectionStringBuilder( )
      {
         DataSource = @"DBSRV\QWERTY",
         //UserID = @"DBSRV\user02",
         //Password = @"8a0IucJ@Nx1Qy5HfFrX0Ob3m",
         UserID = @"user02",
         Password = @"user02",
         InitialCatalog = @"Sales"
      };

      public Form1()
      {
         this.InitializeComponent( );
         {
            this.aqbSqliteGridControl.DataSource = this.dataTable;
         }
      }


      private void testAQBSqliteAUTOConnectionBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         MetadataPullerXtraUserControl.CreateFirstTableSqlite( this.sqliteCSBuilder.ConnectionString );
         using( ActiveQueryBuilder.Core.SQLContext sqlContext = MetadataPullerXtraUserControl.CreateAqbQbAuto( this.sqliteCSBuilder.ConnectionString ) )
         {
            this.dataTable = MetadataPullerXtraUserControl.CreateMetadataItemTable( );
            MetadataPullerXtraUserControl.DrillDownAqbSqlContext( sqlContext, this.dataTable, "XPTO" );
            this.aqbSqliteGridControl.DataSource = this.dataTable;
         }
      }

      private void testAQBSqliteConnectionBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         MetadataPullerXtraUserControl.CreateFirstTableSqlite( this.sqliteCSBuilder.ConnectionString );
         using( ActiveQueryBuilder.Core.SQLContext sqlContext = MetadataPullerXtraUserControl.CreateAqbSqlContext4SQLiteOnline( this.sqliteCSBuilder.ConnectionString ) )
         {
            this.dataTable = MetadataPullerXtraUserControl.CreateMetadataItemTable( );
            MetadataPullerXtraUserControl.DrillDownAqbSqlContext( sqlContext, this.dataTable, "XPTO" );
            this.aqbSqliteGridControl.DataSource = this.dataTable;
         }
      }

      private void testAQBMsssAutoConnectionBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         using( ActiveQueryBuilder.Core.SQLContext sqlContext = MetadataPullerXtraUserControl.CreateAqbQbMSSS( this.msssCSBuilder.ConnectionString ) )
         {
            this.dataTable = MetadataPullerXtraUserControl.CreateMetadataItemTable( );
            MetadataPullerXtraUserControl.DrillDownAqbSqlContext( sqlContext, this.dataTable, "XPTO" );
            this.aqbSqliteGridControl.DataSource = this.dataTable;
         }
      }
   }
}

/*

      #region --- Active Query Builder ---
      public static bool TestAqbSqlContext4SQLiteConnection(string cs)
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext()
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider(),
            MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider()
            {
               Connection = new System.Data.SQLite.SQLiteConnection()
               {
                  ConnectionString = cs
               }
            }
         };
         {
            // sc.MetadataContainer.LoadingOptions.OfflineMode = false;
            // sc.MetadataContainer.LoadingOptions.LoadSystemObjects = false;
            // sc.MetadataContainer.LoadingOptions.LoadDefaultDatabaseOnly = true;
            sc.LoadingOptions.OfflineMode = false;
            sc.LoadingOptions.LoadSystemObjects = false;
            sc.LoadingOptions.LoadDefaultDatabaseOnly = true;
            sc.MetadataContainer.LoadAll(false);
         }
         ActiveQueryBuilder.Core.MetadataList items = sc.MetadataContainer.Items;
         return items == null ? false : true;
      }

      public static ActiveQueryBuilder.Core.SQLContext CreateAqbSqlContext4SQLiteOffline(string filepath)
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext()
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider(),
            //MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider( )
            //{
            //   Connection = new System.Data.SQLite.SQLiteConnection( )
            //   {
            //      ConnectionString = cs.ConnectionString
            //   }
            //}
         };
         {
            sc.MetadataContainer.LoadingOptions.OfflineMode = true;
            sc.MetadataContainer.ImportFromXML(filepath);
         }
         return sc;
      }

      public static ActiveQueryBuilder.Core.SQLContext CreateAqbSqlContext4SQLiteOnline(string cs)
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext()
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider(),
            MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider()
            {
               Connection = new System.Data.SQLite.SQLiteConnection()
               {
                  ConnectionString = cs
               }
            }
         };
         {
            sc.MetadataContainer.LoadAll(true);
            //   sc.MetadataContainer.LoadAll( WithField );
            //   sc.MetadataContainer.LoadingOptions.OfflineMode = true;
            //   sc.MetadataContainer.ImportFromXML( filepath );
         }
         return sc;
      }
      #endregion


      private void testSqliteConnectionBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder( @"Data Source=D:\TEMP\SQLite\mydb.db;Version=3;Password=myPassword;" );
         builder.BaseSchemaName = "saschama";
         //builder.DataSource = "_ds_";
         //builder.Password = "sa";
         //
         string str = builder.ToString( );

         using( SQLiteConnection conn = new SQLiteConnection( builder.ConnectionString ) )
         {
            conn.Open( );
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand( sql, conn );
            command.ExecuteNonQuery( );
         }
      }

      private void testMsssConnectionBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder( );
         builder.DataSource = @"DBSRV\QWERTY";
         builder.UserID = @"DBSRV\user02";
         builder.Password = @"8a0IucJ@Nx1Qy5HfFrX0Ob3m";
         builder.UserID = @"user03";
         builder.Password = @"user03";
         builder.InitialCatalog = @"Sales";
         //
         string str = builder.ToString( );

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


*/
