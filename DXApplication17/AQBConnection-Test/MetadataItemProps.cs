using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Xml.Serialization;

namespace AQBConnection_Test
{
   public partial class MetadataItemProps
   {
      private DataRow o;

      #region --- ID ---
      public const string ID_FIELDNAME = "ID";
      public const string ID_DISPLAYNAME = "ID";
      public const string ID_DESCRIPTION = null;
      public const string ID_CATEGORY = "IDs";
      public const string ID_XMLNAME = "id";
      [DisplayName( ID_DISPLAYNAME )]
      [Description( ID_DESCRIPTION )]
      [Category( PARENT_ID_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( ID_XMLNAME )]
      public int ID
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[ ID_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ ID_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- PARENT ID ---
      public const string PARENT_ID_FIELDNAME = "ParentID";
      public const string PARENT_ID_DISPLAYNAME = "Parent ID";
      public const string PARENT_ID_DESCRIPTION = null;
      public const string PARENT_ID_CATEGORY = "IDs";
      public const string PARENT_ID_XMLNAME = "pid";
      [DisplayName( PARENT_ID_DISPLAYNAME )]
      [Description( PARENT_ID_DESCRIPTION )]
      [Category( PARENT_ID_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( PARENT_ID_XMLNAME )]
      public int ParentID
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[ PARENT_ID_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ PARENT_ID_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- METADATA PROVIDER ---
      public const string METADATA_PROVIDER_FIELDNAME = "MetadataProvider";
      public const string METADATA_PROVIDER_DISPLAYNAME = "Metadata Provider";
      public const string METADATA_PROVIDER_DESCRIPTION = null;
      public const string METADATA_PROVIDER_CATEGORY = "Query Builder";
      public const string METADATA_PROVIDER_XMLNAME = "mp";
      [DisplayName( METADATA_PROVIDER_DISPLAYNAME )]
      [Description( METADATA_PROVIDER_DESCRIPTION )]
      [Category( METADATA_PROVIDER_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( METADATA_PROVIDER_XMLNAME )]
      public string MetadataProvider
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ METADATA_PROVIDER_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ METADATA_PROVIDER_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- SYNTAX PROVIDER ---
      public const string SYNTAX_PROVIDER_FIELDNAME = "SyntaxProvider";
      public const string SYNTAX_PROVIDER_DISPLAYNAME = "Syntax Provider";
      public const string SYNTAX_PROVIDER_DESCRIPTION = null;
      public const string SYNTAX_PROVIDER_CATEGORY = "Query Builder";
      public const string SYNTAX_PROVIDER_XMLNAME = "sp";
      [DisplayName( SYNTAX_PROVIDER_DISPLAYNAME )]
      [Description( SYNTAX_PROVIDER_DESCRIPTION )]
      [Category( SYNTAX_PROVIDER_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( SYNTAX_PROVIDER_XMLNAME )]
      public string SyntaxProvider
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ SYNTAX_PROVIDER_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ SYNTAX_PROVIDER_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- TYPE ---
      public const string TYPE_FIELDNAME = "Type";
      public const string TYPE_DISPLAYNAME = "Type";
      public const string TYPE_DESCRIPTION = null;
      public const string TYPE_CATEGORY = "Types";
      public const string TYPE_XMLNAME = "tp";
      [DisplayName( TYPE_DISPLAYNAME )]
      [Description( TYPE_DESCRIPTION )]
      [Category( TYPE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( TYPE_XMLNAME )]
      public string Type
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ TYPE_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ TYPE_FIELDNAME ] = value;
         }
      }

      #endregion

      #region --- PARENT TYPE ---
      public const string PARENT_TYPE_FIELDNAME = "ParentType";
      public const string PARENT_TYPE_DISPLAYNAME = "Parent Type";
      public const string PARENT_TYPE_DESCRIPTION = null;
      public const string PARENT_TYPE_CATEGORY = "Types";
      public const string PARENT_TYPE_XMLNAME = "pt";
      [DisplayName( PARENT_TYPE_DISPLAYNAME )]
      [Description( PARENT_TYPE_DESCRIPTION )]
      [Category( PARENT_TYPE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( PARENT_TYPE_XMLNAME )]
      public string ParentType
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ PARENT_TYPE_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ PARENT_TYPE_FIELDNAME ] = value;
         }
      }

      #endregion

      #region --- IS SYSTEM ---
      public const string IS_SYSTEM_FIELDNAME = "IsSystem";
      public const string IS_SYSTEM_DISPLAYNAME = "Is System?";
      public const string IS_SYSTEM_DESCRIPTION = null;
      public const string IS_SYSTEM_CATEGORY = "Types";
      public const string IS_SYSTEM_XMLNAME = "pt";
      [DisplayName( IS_SYSTEM_DISPLAYNAME )]
      [Description( IS_SYSTEM_DESCRIPTION )]
      [Category( IS_SYSTEM_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( IS_SYSTEM_XMLNAME )]
      public bool IsSystem
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (bool) this.o[ IS_SYSTEM_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ IS_SYSTEM_FIELDNAME ] = value;
         }
      }

      #endregion

      #region --- CARDINALITY ---
      public const string CARDINALYTY_FIELDNAME = "Cardinality";
      public const string CARDINALYTY_DISPLAYNAME = "FK Cardinality";
      public const string CARDINALYTY_DESCRIPTION = null;
      public const string CARDINALYTY_CATEGORY = "Cardinality";
      public const string CARDINALYTY_XMLNAME = "cd";
      [DisplayName( CARDINALYTY_DISPLAYNAME )]
      [Description( CARDINALYTY_DESCRIPTION )]
      [Category( CARDINALYTY_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( CARDINALYTY_XMLNAME )]
      public string Cardinality
      {
         //[System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ CARDINALYTY_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ CARDINALYTY_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- FIELDS_COUNT ---
      public const string FIELDSCOUNT_FIELDNAME = "FieldsCount";
      public const string FIELDSCOUNT_DISPLAYNAME = "FK Fields Count";
      public const string FIELDSCOUNT_DESCRIPTION = null;
      public const string FIELDSCOUNT_CATEGORY = CARDINALYTY_CATEGORY;
      public const string FIELDSCOUNT_XMLNAME = "fc";
      [DisplayName( FIELDSCOUNT_DISPLAYNAME )]
      [Description( FIELDSCOUNT_DESCRIPTION )]
      [Category( FIELDSCOUNT_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( FIELDSCOUNT_XMLNAME )]
      public int FieldsCount
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            int value = (int) this.o[ FIELDSCOUNT_FIELDNAME ];
            return value;
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ FIELDSCOUNT_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- FIELDS ---
      public const string FIELDS_FIELDNAME = "Fields";
      public const string FIELDS_DISPLAYNAME = "FK Fields";
      public const string FIELDS_DESCRIPTION = null;
      public const string FIELDS_CATEGORY = CARDINALYTY_CATEGORY;
      public const string FIELDS_XMLNAME = "fds";
      [DisplayName( FIELDS_DISPLAYNAME )]
      [Description( FIELDS_DESCRIPTION )]
      [Category( FIELDS_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( FIELDS_XMLNAME )]
      public List<string> Fields
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            List<string> l = new List<string>();
            l.Add( this.o[ FIELDS_FIELDNAME ].ToString( ) );
            return l;
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            //this.o[ FIELDS_FIELDNAME ] = value;
         }
      }
      #endregion

      public override string ToString()
      {
         //return string.Format("0:{1}", this.Type, this.NameFullQualified);
         return base.ToString( );
      }

      public MetadataItemProps( DataRow row )
      {
         this.o = row;
      }
   }
}

/*
      #region --- TS_STR ---
      public const string TS_MASK_FORMAT = "{0:yyyyMMdd-HHmmss-ffffzzz}";
      [System.ComponentModel.DataAnnotations.Display( AutoGenerateField = false )]
      [System.Xml.Serialization.XmlIgnore]
      public static string TS_STR
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return string.Format( TS_MASK_FORMAT, System.DateTime.Now );
         }
      }
      #endregion




      public const string REFERENCED_CARDINALYTY_NAME_FIELDNAME = "ReferencedCardinality";
      public const string REFERENCED_CARDINALYTY_NAME_DISPLAYNAME = "TK Cardinality";
      [System.Xml.Serialization.XmlElement( "rc" )]
      public string ReferencedCardinality
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }


      public const string REFERENCED_OBJECT_FIELDNAME = "ReferencedObject";
      public const string REFERENCED_OBJECT_DISPLAYNAME = "TK Object";
      [System.Xml.Serialization.XmlElement( "ro" )]
      public string ReferencedObject
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string REFERENCED_OBJECT_NAME_FIELDNAME = "ReferencedObjectName";
      public const string REFERENCED_OBJECT_NAME_DISPLAYNAME = "TK Object Name";
      [System.Xml.Serialization.XmlElement( "ron" )]
      public string ReferencedObjectName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string REFERENCED_FIELDS_COUNT_FIELDNAME = "ReferencedFieldsCount";
      public const string REFERENCED_FIELDS_COUNT_DISPLAYNAME = "TK Fields Count";
      [System.Xml.Serialization.XmlElement( "rfc" )]
      public int ReferencedFieldsCount
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string REFERENCED_FIELDS_FIELDNAME = "ReferencedFields";
      public const string REFERENCED_FIELDS_DISPLAYNAME = "TK Fields";
      [System.Xml.Serialization.XmlElement( "rf" )]
      public string ReferencedFields
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string SERVER_FIELDNAME = "Server";
      [System.Xml.Serialization.XmlElement( "svr" )]
      public string Server
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string DATABASE_FIELDNAME = "Database";
      [System.Xml.Serialization.XmlElement( "db" )]
      public string Database
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string SCHEMA_FIELDNAME = "Schema";
      [System.Xml.Serialization.XmlElement( "sch" )]
      public string Schema
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string OBJECT_FIELDNAME = "ObjectName";
      public const string OBJECT_DISPLAYNAME = "Parent Name";
      [System.Xml.Serialization.XmlElement( "on" )]
      public string ObjectName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string NAMEFULLQUALIFIED_FIELDNAME = "NameFullQualified";
      public const string NAMEFULLQUALIFIED_DISPLAYNAME = "Name Full Qualified";
      [System.Xml.Serialization.XmlElement( "nfq" )]
      public string NameFullQualified
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string NAMEQUOTED_FIELDNAME = "NameQuoted";
      [System.Xml.Serialization.XmlElement( "nq" )]
      public string NameQuoted
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string ALTNAME_FIELDNAME = "AltName";
      [System.Xml.Serialization.XmlElement( "an" )]
      public string AltName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string FIELD_FIELDNAME = "Field";
      public const string FIELD_DISPLAYNAME = "Name";
      [System.Xml.Serialization.XmlElement( "fld" )]
      public string Field
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlAttribute]
      public bool HasDefault
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string EXPRESSION_FIELDNAME = "Expression";
      [System.Xml.Serialization.XmlElement( "xpr" )]
      public string Expression
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string FIELD_TYPE_FIELDNAME = "FieldType";
      public const string FIELD_TYPE_DISPLAYNAME = ".Net Type Name";
      [System.Xml.Serialization.XmlElement( "ft" )]
      public string FieldType
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string FIELD_TYPE_NAME_FIELDNAME = "FieldTypeName";
      public const string FIELD_TYPE_NAME_DISPLAYNAME = "Database Type Name";
      [System.Xml.Serialization.XmlElement( "ftn" )]
      public string FieldTypeName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlAttribute]
      public bool IsNullable
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlElement( "prec" )]
      public int Precision
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlElement( "sc" )]
      public int Scale
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlElement( "sz" )]
      public long Size
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string IS_PK_FIELDNAME = "IsPK";
      [System.Xml.Serialization.XmlAttribute]
      public bool IsPK
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string IS_READONLY_FIELDNAME = "IsRO";
      [System.Xml.Serialization.XmlAttribute]
      public bool IsRO
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string DESCRIPTION_FIELDNAME = "Description";
      [System.Xml.Serialization.XmlElement( "dscr" )]
      public string Description
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string TAG_FIELDNAME = "Tag";
      public object Tag
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string USERDATA_FIELDNAME = "UserData";
      [System.Xml.Serialization.XmlElement( "ud" )]
      public string UserData
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

*/
