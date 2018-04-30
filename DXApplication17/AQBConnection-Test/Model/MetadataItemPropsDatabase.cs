using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsDatabase : MetadataItemProps
   {
      public MetadataItemPropsDatabase( DataRow row )
         : base( row )
      {
      }

      [Browsable( false )]
      public new string SnapshotFile
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new System.DateTime LastWriteTimeUtc
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string Cardinality
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new int FieldsCount
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new List<string> Fields
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string ReferencedCardinality
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string ReferencedObject
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string ReferencedObjectName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new int ReferencedFieldsCount
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new List<string> ReferencedFields
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string Schema
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string ObjectName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string NameFullQualified
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string NameQuoted
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string AltName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [Browsable( false )]
      public new string Field
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      /*


            #region --- HAS DEFAULT ---
            public const string HAS_DEFAULT_FIELDNAME = "HasDefault";
            public const string HAS_DEFAULT_DISPLAYNAME = "Has Default?";
            public const string HAS_DEFAULT_DESCRIPTION = null;
            public const string HAS_DEFAULT_CATEGORY = "Misc";
            public const string HAS_DEFAULT_XMLNAME = "hd";
            [DisplayName( HAS_DEFAULT_DISPLAYNAME )]
            [Description( HAS_DEFAULT_DESCRIPTION )]
            [Category( HAS_DEFAULT_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlAttribute( HAS_DEFAULT_XMLNAME )]
            public bool HasDefault
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return (Boolean) this.o[ HAS_DEFAULT_FIELDNAME ];
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ HAS_DEFAULT_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- EXPRESSION ---
            public const string EXPRESSION_FIELDNAME = "Expression";
            public const string EXPRESSION_DISPLAYNAME = "Expression";
            public const string EXPRESSION_DESCRIPTION = null;
            public const string EXPRESSION_CATEGORY = "Misc";
            public const string EXPRESSION_XMLNAME = "xpr";
            [DisplayName( EXPRESSION_DISPLAYNAME )]
            [Description( EXPRESSION_DESCRIPTION )]
            [Category( EXPRESSION_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( EXPRESSION_XMLNAME )]
            public string Expression
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return this.o[ EXPRESSION_FIELDNAME ].ToString( );
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ EXPRESSION_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- FIELD TYPE ---
            public const string FIELD_TYPE_FIELDNAME = "FieldType";
            public const string FIELD_TYPE_DISPLAYNAME = ".Net Type Name";
            public const string FIELD_TYPE_DESCRIPTION = null;
            public const string FIELD_TYPE_CATEGORY = "Misc";
            public const string FIELD_TYPE_XMLNAME = "ft";
            [DisplayName( FIELD_TYPE_DISPLAYNAME )]
            [Description( FIELD_TYPE_DESCRIPTION )]
            [Category( FIELD_TYPE_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( FIELD_TYPE_XMLNAME )]
            public string FieldType
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return this.o[ FIELD_TYPE_FIELDNAME ].ToString( );
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ FIELD_TYPE_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- FIELD TYPE NAME ---
            public const string FIELD_TYPE_NAME_FIELDNAME = "FieldTypeName";
            public const string FIELD_TYPE_NAME_DISPLAYNAME = "Database Type Name";
            public const string FIELD_TYPE_NAME_DESCRIPTION = null;
            public const string FIELD_TYPE_NAME_CATEGORY = "Misc";
            public const string FIELD_TYPE_NAME_XMLNAME = "ftn";
            [DisplayName( FIELD_TYPE_NAME_DISPLAYNAME )]
            [Description( FIELD_TYPE_NAME_DESCRIPTION )]
            [Category( FIELD_TYPE_NAME_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( FIELD_TYPE_NAME_XMLNAME )]
            public string FieldTypeName
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return this.o[ FIELD_TYPE_NAME_FIELDNAME ].ToString( );
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ FIELD_TYPE_NAME_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- IS NULLABLE ---
            public const string IS_NULLABLE_FIELDNAME = "IsNullable";
            public const string IS_NULLABLE_DISPLAYNAME = "Is Nullable?";
            public const string IS_NULLABLE_DESCRIPTION = null;
            public const string IS_NULLABLE_CATEGORY = "Misc";
            public const string IS_NULLABLE_XMLNAME = "nlb";
            [DisplayName( IS_NULLABLE_DISPLAYNAME )]
            [Description( IS_NULLABLE_DESCRIPTION )]
            [Category( IS_NULLABLE_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlAttribute( IS_NULLABLE_XMLNAME )]
            public bool IsNullable
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return (Boolean) this.o[ IS_NULLABLE_FIELDNAME ];
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ IS_NULLABLE_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- PREC ---
            public const string PRECISION_FIELDNAME = "Precision";
            public const string PRECISION_DISPLAYNAME = "Prec";
            public const string PRECISION_DESCRIPTION = null;
            public const string PRECISION_CATEGORY = "Misc";
            public const string PRECISION_XMLNAME = "prec";
            [DisplayName( PRECISION_DISPLAYNAME )]
            [Description( PRECISION_DESCRIPTION )]
            [Category( PRECISION_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( PRECISION_XMLNAME )]
            public int Precision
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return (int) this.o[ PRECISION_FIELDNAME ];
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ PRECISION_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- SCALE ---
            public const string SCALE_FIELDNAME = "Scale";
            public const string SCALE_DISPLAYNAME = "Scale";
            public const string SCALE_DESCRIPTION = null;
            public const string SCALE_CATEGORY = "Misc";
            public const string SCALE_XMLNAME = "sc";
            [DisplayName( SCALE_DISPLAYNAME )]
            [Description( SCALE_DESCRIPTION )]
            [Category( SCALE_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( SCALE_XMLNAME )]
            public int Scale
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return (int) this.o[ SCALE_FIELDNAME ];
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ SCALE_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- SIZE ---
            public const string SIZE_FIELDNAME = "Size";
            public const string SIZE_DISPLAYNAME = "Size";
            public const string SIZE_DESCRIPTION = null;
            public const string SIZE_CATEGORY = "Misc";
            public const string SIZE_XMLNAME = "sz";
            [DisplayName( SIZE_DISPLAYNAME )]
            [Description( SIZE_DESCRIPTION )]
            [Category( SIZE_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( SIZE_XMLNAME )]
            public long Size
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return (int) this.o[ SIZE_FIELDNAME ];
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ SIZE_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- IS PK ? ---
            public const string IS_PK_FIELDNAME = "IsPK";
            public const string IS_PK_DISPLAYNAME = "Is PK?";
            public const string IS_PK_DESCRIPTION = null;
            public const string IS_PK_CATEGORY = "Keys";
            public const string IS_PK_XMLNAME = "pk";
            [DisplayName( IS_PK_DISPLAYNAME )]
            [Description( IS_PK_DESCRIPTION )]
            [Category( IS_PK_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlAttribute( IS_PK_XMLNAME )]
            public bool IsPK
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return (Boolean) this.o[ IS_PK_FIELDNAME ];
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ IS_PK_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- IS READONLY ? ---
            public const string IS_READONLY_FIELDNAME = "IsRO";
            public const string IS_READONLY_DISPLAYNAME = "Is R/O?";
            public const string IS_READONLY_DESCRIPTION = null;
            public const string IS_READONLY_CATEGORY = "Misc";
            public const string IS_READONLY_XMLNAME = "ro";
            [DisplayName( IS_READONLY_DISPLAYNAME )]
            [Description( IS_READONLY_DESCRIPTION )]
            [Category( IS_READONLY_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlAttribute( IS_READONLY_XMLNAME )]
            public bool IsRO
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return (Boolean) this.o[ IS_READONLY_FIELDNAME ];
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ IS_READONLY_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- DESCRIPTION ---
            public const string DESCRIPTION_FIELDNAME = "Description";
            public const string DESCRIPTION_DISPLAYNAME = "Description";
            public const string DESCRIPTION_DESCRIPTION = null;
            public const string DESCRIPTION_CATEGORY = "Misc";
            public const string DESCRIPTION_XMLNAME = "dscr";
            [DisplayName( DESCRIPTION_DISPLAYNAME )]
            [Description( DESCRIPTION_DESCRIPTION )]
            [Category( DESCRIPTION_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( DESCRIPTION_XMLNAME )]
            public string Description
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return this.o[ DESCRIPTION_FIELDNAME ].ToString( );
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ DESCRIPTION_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- TAG ---
            public const string TAG_FIELDNAME = "Tag";
            public const string TAG_DISPLAYNAME = "Tag";
            public const string TAG_DESCRIPTION = null;
            public const string TAG_CATEGORY = "Misc";
            public const string TAG_XMLNAME = "tag";
            [DisplayName( TAG_DISPLAYNAME )]
            [Description( TAG_DESCRIPTION )]
            [Category( TAG_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( TAG_XMLNAME )]
            public object Tag
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return this.o[ TAG_FIELDNAME ];
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ TAG_FIELDNAME ] = value;
               }
            }
            #endregion

            #region --- USERDATA ---
            public const string USERDATA_FIELDNAME = "UserData";
            public const string USERDATA_DISPLAYNAME = "Tag";
            public const string USERDATA_DESCRIPTION = null;
            public const string USERDATA_CATEGORY = "Misc";
            public const string USERDATA_XMLNAME = "ud";
            [DisplayName( USERDATA_DISPLAYNAME )]
            [Description( USERDATA_DESCRIPTION )]
            [Category( USERDATA_CATEGORY )]
            [ReadOnly( true )]
            [Browsable( true )]
            [XmlElement( USERDATA_XMLNAME )]
            public string UserData
            {
               [System.Diagnostics.DebuggerStepThrough]
               get
               {
                  return this.o[ USERDATA_FIELDNAME ].ToString( );
               }
               [System.Diagnostics.DebuggerStepThrough]
               set
               {
                  this.o[ USERDATA_FIELDNAME ] = value;
               }
            }
            #endregion
      */

   }
}
