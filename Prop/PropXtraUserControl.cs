using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraVerticalGrid.Rows;
using System;
using System.Linq;

namespace Prop
{
   public partial class PropXtraUserControl : XtraUserControl
   {
      public PropXtraUserControl()
      {
         this.InitializeComponent( );
      }

      internal void SetSelectedObject( object o )
      {
         this.propertyGridControl.SelectedObject = o;
      }

      private void categoryBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         this.propertyGridControl.OptionsView.ShowRootCategories = true;
         this.alphabeticBarButtonItem.Enabled = true;
         this.categoryBarButtonItem.Enabled = false;
      }

      private void alphabeticBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         this.propertyGridControl.OptionsView.ShowRootCategories = false;
         this.alphabeticBarButtonItem.Enabled = false;
         this.categoryBarButtonItem.Enabled = true;
      }

      private void expandBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         this.propertyGridControl.FocusedRow.Expanded = true;
         this.VerifyStatuses( );
      }

      private void collapseBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         BaseRow focusedRow = this.propertyGridControl.FocusedRow;
         bool hasParent = focusedRow.ParentRow != null;
         bool hasChildren = focusedRow.HasChildren;
         bool isExpanded = focusedRow.Expanded;
         if( hasChildren && isExpanded )
         {
            this.propertyGridControl.FocusedRow.Expanded = false;
         }
         else if( hasParent )
         {
            focusedRow.ParentRow.Expanded = false;
         }
         this.VerifyStatuses( );
      }

      private void propertyGridControl_FocusedRowChanged( object sender, FocusedRowChangedEventArgs e )
      {
         this.VerifyStatuses( );
      }

      private void VerifyStatuses()
      {
         BaseRow focusedRow = this.propertyGridControl.FocusedRow;
         bool isCategoryRow = this.propertyGridControl.IsCategoryRow( focusedRow );
         bool hasParent = focusedRow.ParentRow != null;
         bool hasChildren = focusedRow.HasChildren;
         bool isExpanded = focusedRow.Expanded;
         this.expandBarButtonItem.Enabled = (hasChildren && !isExpanded);
         this.collapseBarButtonItem.Enabled = (hasChildren && isExpanded) || hasParent;
      }
   }
}
