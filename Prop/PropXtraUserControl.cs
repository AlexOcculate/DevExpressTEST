using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraVerticalGrid.Rows;
using System;
using System.ComponentModel;
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

      private void propertyGridControl_CustomPropertyDescriptors( object sender, CustomPropertyDescriptorsEventArgs e )
      {
         // Provide properties to be displayed at the root level
         if( e.Context.PropertyDescriptor == null )
         {
            if( this.allowCustomSorting )
            {
               PropertyDescriptorCollection asc = e.Properties.Sort( );
               string[ ] keys = new string[ asc.Count ];
               for( int i = 0; i < asc.Count; i++ )
               {
                  keys[ i ] = asc[ i ].Name;
               }
               Array.Reverse( keys );
               e.Properties = e.Properties.Sort( keys );
            }
            //PropertyDescriptorCollection filteredCollection = new PropertyDescriptorCollection( null );
            //this.AddIfPropertyExist( e.Properties, filteredCollection, nameof( Dock ) );
            //this.AddIfPropertyExist( e.Properties, filteredCollection, nameof( Size ) );
            //this.AddIfPropertyExist( e.Properties, filteredCollection, nameof( Location ) );
            //this.AddIfPropertyExist( e.Properties, filteredCollection, "NonexistentProperty" );
            //e.Properties = filteredCollection;
         }
         //Provide nested properties for the Size property
         //if( e.Context.PropertyDescriptor != null && e.Context.PropertyDescriptor.Name == nameof( Size ) )
         //{
         //   PropertyDescriptorCollection filteredCollection = new PropertyDescriptorCollection( null );
         //   this.AddIfPropertyExist( e.Properties, filteredCollection, nameof( Height ) );
         //   e.Properties = filteredCollection;
         //}
      }

      private void AddIfPropertyExist(
         PropertyDescriptorCollection sourceCollection,
         PropertyDescriptorCollection targetCollection,
         string name
         )
      {
         PropertyDescriptor foundPropertyDescriptor = sourceCollection[ name ];
         if( foundPropertyDescriptor == null )
         {
            return;
         }

         targetCollection.Add( foundPropertyDescriptor );
      }

      private bool allowCustomSorting = false;

      private void alphabeticDescBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         this.allowCustomSorting = !this.allowCustomSorting;
         this.propertyGridControl.OptionsBehavior.PropertySort
            = this.allowCustomSorting
            ? DevExpress.XtraVerticalGrid.PropertySort.NoSort
            : DevExpress.XtraVerticalGrid.PropertySort.Alphabetical;
         this.propertyGridControl.Refresh( );
         this.propertyGridControl.RetrieveFields( );
      }
   }
}
