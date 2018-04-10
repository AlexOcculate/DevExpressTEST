using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Prop
{
   public partial class PropXtraUserControl : DevExpress.XtraEditors.XtraUserControl
   {
      public PropXtraUserControl()
      {
         InitializeComponent( );
      }

      internal void SetSelectedObject( object o )
      {
         this.propertyGridControl1.SelectedObject = o;
      }

      private void sortOrderBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void expandBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {


      }
   }
}
