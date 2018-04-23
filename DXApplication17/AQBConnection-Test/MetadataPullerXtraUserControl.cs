using System;
using System.Data.SQLite;
using System.Linq;

namespace DPControls.Controls.MetadataPuller
{
   public partial class MetadataPullerXtraUserControl
   {
      public MetadataPullerXtraUserControl()
      {
      }

      public static void CreateFirstTableSqlite(string connectionString)
      {
         //SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder( );
         //builder.DataSource = @"D:\TEMP\SQLite\mydb.db";
         //
         using( SQLiteConnection conn = new SQLiteConnection( connectionString ) )
         {
            conn.Open( );
            string sql = "create table if not exists highscores (name varchar(20), score int)";
            using( SQLiteCommand command = new SQLiteCommand( sql, conn ) )
            {
               command.ExecuteNonQuery( );
            }
         }
      }

      /*
      https://support.activequerybuilder.com/hc/en-us/articles/115001055349-Getting-started-with-AQB-NET-3-in-the-Separated-Controls-UI-or-Non-visual-mode
      
      Your initialization code will look as follows:
      
      // Non-visual objects
      _sqlContext = new SQLContext
      {
      SyntaxProvider = new MSSQLSyntaxProvider 
      {
      ServerVersion = MSSQLServerVersion.MSSQL2012
      },
      MetadataProvider = new OLEDBMetadataProvider 
      {
      Connection = new OleDbConnection() 
      {
      ConnectionString = ""
      }
      }
      };
      
      _sqlQuery = new SQLQuery(_sqlContext);
      
      Sergey Smagin
      Ok, then you need only the SQLContext object.
      
      sqlContext.MetadataContainer.ExportToXML();
      
      */

      #region --- Active Query Builder ---
      public static bool TestAqbSqlContext4SQLiteConnection( string cs )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider( )
            {
               Connection = new System.Data.SQLite.SQLiteConnection( )
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
            sc.MetadataContainer.LoadAll( false );
         }
         ActiveQueryBuilder.Core.MetadataList items = sc.MetadataContainer.Items;
         return items == null ? false : true;
      }

      public static ActiveQueryBuilder.Core.SQLContext CreateAqbSqlContext4SQLiteOffline( string filepath )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider( ),
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
            sc.MetadataContainer.ImportFromXML( filepath );
         }
         return sc;
      }

      #region --- SQLite Handle and AQB-QB ---
      public static ActiveQueryBuilder.Core.SQLContext CreateAqbSqlContext4SQLiteOnline( string cs )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider( )
            {
               Connection = new System.Data.SQLite.SQLiteConnection( )
               {
                  ConnectionString = cs
               }
            }
         };
         //{
         //   sc.MetadataContainer.LoadAll( WithField );
         //   sc.MetadataContainer.LoadingOptions.OfflineMode = true;
         //   sc.MetadataContainer.ImportFromXML( filepath );
         //}
         return sc;
      }
      #endregion

      #region --- Auto Handle and AQB-QB ---
      public static ActiveQueryBuilder.Core.SQLContext CreateAqbQbAuto( string connectionString )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.AutoSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.UniversalMetadataProvider( )
         };
         //qb.MetadataProvider.Connection = new System.Data.SqlClient.SqlConnection( ds.ConnectionString );
         sc.MetadataProvider.Connection = new System.Data.SQLite.SQLiteConnection( connectionString );
         {
            sc.LoadingOptions.OfflineMode = false;
            sc.LoadingOptions.LoadSystemObjects = true;
            sc.LoadingOptions.LoadDefaultDatabaseOnly = false;
            sc.MetadataContainer.LoadAll( true );
         }
         return sc;
      }
      #endregion

      #region --- MSSS Handle and AQB-QB ---
      public static ActiveQueryBuilder.Core.SQLContext CreateAqbQbMSSS( string connectionString )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.MSSQLMetadataProvider( )
         };
         //qb.MetadataProvider.Connection = new System.Data.SQLite.SQLiteConnection( ds.ConnectionString );
         sc.MetadataProvider.Connection = new System.Data.SqlClient.SqlConnection( connectionString );
         {
            sc.LoadingOptions.OfflineMode = false;
            sc.LoadingOptions.LoadSystemObjects = false;
            sc.LoadingOptions.LoadDefaultDatabaseOnly = true;
            sc.MetadataContainer.LoadAll( true );
         }
         return sc;
      }
      #endregion

      private class StackItem
      {
         public ActiveQueryBuilder.Core.MetadataList list;
         public int index;
         public int parentID;
         public int grandParentID;
      }

      public static void DrillDownAqbSqlContext(
         ActiveQueryBuilder.Core.SQLContext sc
         , System.Data.DataTable tbl
         , string dataStoreName
         )
      {
         ActiveQueryBuilder.Core.MetadataList items = sc.MetadataContainer.Items;
         //
         System.Collections.Generic.Stack<StackItem> stack = new System.Collections.Generic.Stack<StackItem>( );
         stack.Push( new StackItem { list = items, index = 0, parentID = -1, grandParentID = -1 } );
         do
         {
            StackItem si = stack.Pop( );
            ActiveQueryBuilder.Core.MetadataList actualMIList = si.list;
            int actualIndex = si.index;
            int actualParentID = si.grandParentID; // IMPORTANT!!!
            for( ; actualIndex < actualMIList.Count; actualIndex++ )
            {
               System.Data.DataRow row = tbl.NewRow( );
               row[ "DataStoreName" ] = dataStoreName;
               ExtractMetadataItem( row, actualMIList[ actualIndex ], actualParentID, tbl );
               tbl.Rows.Add( row );
               if( actualMIList[ actualIndex ].Items.Count > 0 ) // branch...
               {
                  int count = tbl.Rows.Count;
                  System.Data.DataRowCollection rows = tbl.Rows;
                  int parentId = (int) rows[ count - 1 ][ "ID" ];
                  // Push the "next" Item...
                  stack.Push( new StackItem
                  {
                     list = actualMIList,
                     index = actualIndex + 1,
                     parentID = parentId,
                     grandParentID = actualParentID
                  } );
                  // Reset the loop to process the "actual" Item...
                  actualParentID = parentId;
                  actualMIList = actualMIList[ actualIndex ].Items;
                  actualIndex = -1;
               }
            } // for(;;)...
         } while( stack.Count > 0 );
      }

      private static void ExtractMetadataItem(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         switch( mi.Type )
         {
            case ActiveQueryBuilder.Core.MetadataType.Database:
            case ActiveQueryBuilder.Core.MetadataType.Schema:
               ExtractNamespace( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Table:
            case ActiveQueryBuilder.Core.MetadataType.View:
               ExtractTable( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Procedure:
               ExtractProcedure( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Synonym:
               ExtractSynonym( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Field:
               ExtractField( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.ForeignKey:
               ExtractForeignKey( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Root:
            case ActiveQueryBuilder.Core.MetadataType.Server:
            case ActiveQueryBuilder.Core.MetadataType.Package:
            case ActiveQueryBuilder.Core.MetadataType.Namespaces:
            case ActiveQueryBuilder.Core.MetadataType.ObjectMetadata:
            case ActiveQueryBuilder.Core.MetadataType.Objects:
            case ActiveQueryBuilder.Core.MetadataType.Aggregate:
            case ActiveQueryBuilder.Core.MetadataType.Parameter:
            case ActiveQueryBuilder.Core.MetadataType.UserQuery:
            case ActiveQueryBuilder.Core.MetadataType.UserField:
            case ActiveQueryBuilder.Core.MetadataType.All:
            default:
               ExtractItem( row, mi, parentID, tbl );
               break;
         }
      }

      private static void ExtractNamespace(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            //ActiveQueryBuilder.Core.MetadataNamespace m = mi as ActiveQueryBuilder.Core.MetadataNamespace;
         }
      }

      private static void ExtractProcedure(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
         }
      }

      private static void ExtractSynonym(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
            row[ "ReferencedObject" ] = m.ReferencedObject?.NameFull;
            //
            for( int i = 0; i < m.ReferencedObjectName.Count; i++ )
            {
               ActiveQueryBuilder.Core.MetadataQualifiedNamePart x = m.ReferencedObjectName[ i ];
               row[ "ReferencedObjectName" ] += "["
               + System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), x.Type )
               + ":"
               + x.Name
               + "]"
            ;
            }
         }
      }

      private static void ExtractTable(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            //ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
         }
      }

      private static void ExtractField(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            ActiveQueryBuilder.Core.MetadataField m = mi as ActiveQueryBuilder.Core.MetadataField;
            row[ "Expression" ] = m.Expression;
            row[ "FieldType" ] = System.Enum.GetName( typeof( System.Data.DbType ), m.FieldType );
            row[ "FieldTypeName" ] = m.FieldTypeName;
            row[ "IsNullable" ] = m.Nullable;
            row[ "Precision" ] = m.Precision;
            row[ "Scale" ] = m.Scale;
            row[ "Size" ] = m.Size;
            row[ "IsPK" ] = m.PrimaryKey;
            row[ "IsRO" ] = m.ReadOnly;
         }
      }

      private static void ExtractForeignKey(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         row[ "FieldType" ] = null;
         {
            ActiveQueryBuilder.Core.MetadataForeignKey m = mi as ActiveQueryBuilder.Core.MetadataForeignKey;
            row[ "ReferencedObject" ] = m.ReferencedObject.NameFull;
            //
            for( int i = 0; i < m.ReferencedObjectName.Count; i++ )
            {
               ActiveQueryBuilder.Core.MetadataQualifiedNamePart x = m.ReferencedObjectName[ i ];
               row[ "ReferencedObjectName" ] += "["
               + System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), x.Type )
               + ":"
               + x.Name
               + "]"
            ;
            }
            //
            row[ "ReferencedFieldsCount" ] = m.ReferencedFields.Count;
            for( int i = 0; i < m.ReferencedFields.Count; i++ )
            {
               row[ "ReferencedFields" ] += "[" + m.ReferencedFields[ i ] + "]";
            }
            //
            row[ "ReferencedCardinality" ] = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataForeignKeyCardinality ), m.ReferencedCardinality );
            //
            row[ "FieldsCount" ] = m.Fields.Count;
            for( int i = 0; i < m.Fields.Count; i++ )
            {
               row[ "Fields" ] += "[" + m.Fields[ i ] + "]"
            ;
            }
            //
            row[ "Cardinality" ] = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataForeignKeyCardinality ), m.Cardinality );
         }
      }

      private static void ExtractItem(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )

      {
         row[ "ID" ] = tbl.Rows.Count;
         row[ "ParentID" ] = parentID;
         row[ "MetadataProvider" ] = mi.SQLContext?.MetadataProvider?.Description;
         row[ "SyntaxProvider" ] = mi.SQLContext?.SyntaxProvider?.Description;
         if( mi.Parent != null )
         {
            row[ "ParentType" ] = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), mi.Parent.Type );
         }
         row[ nameof( Type ) ] = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), mi.Type );
         row[ "IsSystem" ] = mi.System;
         ////
         //string rootName = mi.Root?.Name;
         row[ "Server" ] = mi.Server?.Name;
         row[ "Database" ] = mi.Database?.Name;
         row[ "Schema" ] = mi.Schema?.Name;
         row[ "ObjectName" ] = mi.Object?.Name;
         ////
         row[ "NameFullQualified" ] = mi.NameFull + (mi.NameFull.EndsWith( "." ) ? "<?>" : string.Empty);
         row[ "NameQuoted" ] = mi.NameQuoted;
         row[ "AltName" ] = mi.AltName;
         row[ "Field" ] = mi.Name != null ? mi.Name : "<?>";
         ////
         row[ "HasDefault" ] = mi.Default;
         row[ "Description" ] = mi.Description;
         row[ "Tag" ] = mi.Tag;
         row[ "UserData" ] = mi.UserData;
      }
      #endregion

      #region --- DATASET ---
      //    public const string DataStoreConfig_TblName = "DataStoreConfig";
      //    public const string DataStoreSnapshotFile_TblName = "DataStoreSnapshotFiles";
      public const string MetadataItem_TblName = "MetadataItem";

      public static System.Data.DataTable CreateMetadataItemTable( string name = MetadataItem_TblName )
      {
         System.Data.DataTable t = new System.Data.DataTable( name );
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = "ID";
            c.Caption = "Id";
            c.ReadOnly = true;
            c.Unique = false;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "DataStoreName";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string ); // typeof( System.IO.FileInfo );
            c.ColumnName = "SnapshotFile";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( System.DateTime );
            c.ColumnName = "LastWriteTimeUtc";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "MetadataProvider";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "SyntaxProvider";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = "ParentID";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = "IsSystem";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = nameof( Type );
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "ParentType";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "Cardinality";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = "FieldsCount";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "Fields";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "ReferencedCardinality";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "ReferencedObject";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "ReferencedObjectName";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = "ReferencedFieldsCount";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "ReferencedFields";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "Server";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "Database";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "Schema";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "ObjectName";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "NameFullQualified";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "NameQuoted";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "AltName";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "Field";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = "HasDefault";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "Expression";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "FieldType";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "FieldTypeName";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = "IsNullable";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = "Precision";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = "Scale";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = "Size";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = "IsPK";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = "IsRO";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "Description";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( object );
            c.ColumnName = "Tag";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = "UserData";
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         return t;
      }
      #endregion
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
