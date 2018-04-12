using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace GridXtraUserControl
{
   public partial class SysCSXtraUserControl : DevExpress.XtraEditors.XtraUserControl
   {
      public SysCSXtraUserControl()
      {
         InitializeComponent( );
         this.gridControl1.DataSource = this.GetSysConnectionStringList( );
      }
      private List<SysConnectionString> _list;
      public List<SysConnectionString> GetSysConnectionStringList()
      {
         if( this._list != null )
            return this._list;
         ConnectionStringSettingsCollection css = ConfigurationManager.ConnectionStrings;
         List<SysConnectionString> list = new List<SysConnectionString>( );
         if( css != null )
         {
            for( int i = 0; i < css.Count; i++ )
            {
               SysConnectionString o = new SysConnectionString( )
               {
                  Name = css[ i ].Name,
                  ProviderName = css[ i ].ProviderName,
                  ConnectionString = css[ i ].ConnectionString,
                  IsSys = true
               };
               list.Add( o );
            }
         }
         return list;
      }

      private void showAllFieldsBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.colIsSys.Visible = !this.colIsSys.Visible;
         this.colProviderName.Visible = !this.colProviderName.Visible;
         this.colConnectionString.Visible = !this.colConnectionString.Visible;
      }

      private void refreshBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this._list = null;
         this.gridControl1.DataSource = this.GetSysConnectionStringList( );
      }

      private void gridView1_FocusedRowObjectChanged( object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e )
      {
         if( e.FocusedRowHandle == -2147483648 )
         {
            return;
         }
         if( e.FocusedRowHandle == -2147483646 )
         {
            return;
         }
      }

      private void showPreviewBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.gridView1.OptionsView.ShowPreview = !this.gridView1.OptionsView.ShowPreview;
      }
   }

   public class SysConnectionString
   {
      public bool IsSys { get; set; }
      public string Name { get; set; }
      public string ProviderName { get; set; }
      public string ConnectionString { get; set; }

   }
}
