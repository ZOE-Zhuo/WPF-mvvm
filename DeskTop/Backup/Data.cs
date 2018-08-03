using System;
using System.Collections.ObjectModel;

namespace DragDrop
{
    class DataItem : ICloneable
    {
        public DataItem(string header)
        {
            mHeader = header;
        }

        public object Clone()
        {
            DataItem dataItem = new DataItem(mHeader);
            foreach (DataItem item in Items)
                dataItem.Items.Add((DataItem)item.Clone());
            return dataItem;
        }

        public string Header
        {
            get { return mHeader; }
        }

        public ObservableCollection<DataItem> Items
        {
            get
            {
                if (mItems == null)
                    mItems = new ObservableCollection<DataItem>();
                return mItems;
            }
        }

        private string mHeader = string.Empty;
        private ObservableCollection<DataItem> mItems = null;
    }

    class Data
    {
        private static Data mInstance = new Data();

        public static Data Instance
        {
            get { return mInstance; }
        }

        private ObservableCollection<DataItem> GenerateTreeViewItems()
        {
            ObservableCollection<DataItem> items = new ObservableCollection<DataItem>();

            DataItem item1 = new DataItem("Item1");
            item1.Items.Add(new DataItem("SubItem1"));
            item1.Items.Add(new DataItem("SubItem2"));
            item1.Items.Add(new DataItem("SubItem3"));
            item1.Items.Add(new DataItem("SubItem4"));
            items.Add(item1);

            DataItem item2 = new DataItem("Item2");
            item2.Items.Add(new DataItem("SubItem1"));
            item2.Items.Add(new DataItem("SubItem2"));
            items.Add(item2);

            return items;
        }

        private ObservableCollection<DataItem> GenerateListItems()
        {
            ObservableCollection<DataItem> items = new ObservableCollection<DataItem>();
            items.Add(new DataItem("Item1"));
            items.Add(new DataItem("Item2"));
            items.Add(new DataItem("Item3"));
            items.Add(new DataItem("Item4"));
            items.Add(new DataItem("Item5"));
            return items;
        }

        public ObservableCollection<DataItem> TreeViewItems
        {
            get
            {
                if (mTreeViewItems == null)
                    mTreeViewItems = GenerateTreeViewItems();
                return mTreeViewItems;
            }
        }

        public ObservableCollection<DataItem> ListBoxItems
        {
            get
            {
                if (mListBoxItems == null)
                    mListBoxItems = GenerateListItems();
                return mListBoxItems;
            }
        }

        private ObservableCollection<DataItem> mTreeViewItems = null;
        private ObservableCollection<DataItem> mListBoxItems = null;
    }
}
