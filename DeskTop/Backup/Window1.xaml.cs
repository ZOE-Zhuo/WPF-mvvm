using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace DragDrop
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            AttachEvents();
        }

        private void AttachEvents()
        {
            mListBox.PreviewMouseMove += OnPreviewListBoxMouseMove;
            mListBox.QueryContinueDrag += OnQueryContinueDrag;
        }

        private void OnPreviewListBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton != MouseButtonState.Pressed)
                return;

            Point pos = e.GetPosition(mListBox);
            HitTestResult result = VisualTreeHelper.HitTest(mListBox, pos);
            if (result == null)
                return;

            ListBoxItem listBoxItem = Utils.FindVisualParent<ListBoxItem>(result.VisualHit); // Find your actual visual you want to drag
            if (listBoxItem == null || listBoxItem.Content != mListBox.SelectedItem || !(mListBox.SelectedItem is DataItem))
                return;

            DragDropAdorner adorner = new DragDropAdorner(listBoxItem);
            mAdornerLayer = AdornerLayer.GetAdornerLayer(mTopLevelGrid); // Window class do not have AdornerLayer
            mAdornerLayer.Add(adorner);

            DataItem dataItem = listBoxItem.Content as DataItem;
            DataObject dataObject = new DataObject(dataItem.Clone());
            // Here, we should notice that dragsource param will specify on which 
            // control the drag&drop event will be fired
            System.Windows.DragDrop.DoDragDrop(mListBox, dataObject, DragDropEffects.Copy);

            mStartHoverTime = DateTime.MinValue;
            mHoveredItem = null;
            mAdornerLayer.Remove(adorner);
            mAdornerLayer = null;
        }

        private void OnQueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            mAdornerLayer.Update();

            UpdateTreeViewExpandingState();
        }

        private void OnDragOver(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.None;

            Point pos = e.GetPosition(mTreeView);
            HitTestResult result = VisualTreeHelper.HitTest(mTreeView, pos);
            if (result == null)
                return;

            TreeViewItem selectedItem = Utils.FindVisualParent<TreeViewItem>(result.VisualHit);
            if (selectedItem != null)
                selectedItem.IsSelected = true;

            e.Effects = DragDropEffects.Copy;
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            Point pos = e.GetPosition(mTreeView);
            HitTestResult result = VisualTreeHelper.HitTest(mTreeView, pos);
            if (result == null)
                return;

            TreeViewItem selectedItem = Utils.FindVisualParent<TreeViewItem>(result.VisualHit);
            if (selectedItem == null)
                return;

            DataItem parent = selectedItem.Header as DataItem;
            DataItem dataItem = e.Data.GetData(typeof(DataItem)) as DataItem;
            if (parent != null && dataItem != null)
                parent.Items.Add(dataItem);
        }

        private void UpdateTreeViewExpandingState()
        {
            Win32.POINT point = new Win32.POINT();
            if (Win32.GetCursorPos(ref point))
            {
                Point pos = new Point(point.X, point.Y);
                pos = mTreeView.PointFromScreen(pos);
                HitTestResult result = VisualTreeHelper.HitTest(mTreeView, pos);
                if (result != null)
                {
                    TreeViewItem selectedItem = Utils.FindVisualParent<TreeViewItem>(result.VisualHit);
                    if (selectedItem != null)
                    {
                        if (mHoveredItem != selectedItem)
                        {
                            mHoveredItem = selectedItem;
                            mStartHoverTime = DateTime.Now;
                        }
                        else
                        {
                            if (mHoveredItem.Items.Count > 0 && !mHoveredItem.IsExpanded &&
                                DateTime.Now - mStartHoverTime > TimeSpan.FromSeconds(2))
                                mHoveredItem.IsExpanded = true;
                        }
                    }
                }
            }
        }

        DateTime mStartHoverTime = DateTime.MinValue;
        TreeViewItem mHoveredItem = null;
        AdornerLayer mAdornerLayer = null;
    }

    internal static class Utils
    {
        public static T FindVisualParent<T>(DependencyObject obj) where T : class
        {
            while (obj != null)
            {
                if (obj is T)
                    return obj as T;

                obj = VisualTreeHelper.GetParent(obj);
            }

            return null;
        }
    }
}
