using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ListView.Model
{
    public class MyTree : NotifyPropertyBase
    {


        #region 父
        public MyTree Parent
        {
            get;
            set;
        }
        #endregion

        #region 子
        public List<MyTree> Children
        {
            get;
            set;
        }
        #endregion

        #region 节点的名字
        public string Name
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MyTree(string name)
        {
            this.Name = name;
            this.Children = new List<MyTree>();
        }
        public MyTree() { }

        public
        #endregion

        #region CheckBox是否选中
       bool? _isChecked;
        public bool? IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                SetIsChecked(value, true, true);
            }
        }

        private void SetIsChecked(bool? value, bool checkedChildren, bool checkedParent)
        {
            if (_isChecked == value) return;
            _isChecked = value;
            //选中和取消子类
            if (checkedChildren && value.HasValue && Children != null)
                Children.ForEach(ch => ch.SetIsChecked(value, true, false));

            //选中和取消父类
            if (checkedParent && this.Parent != null)
                this.Parent.CheckParentCheckState();

            //通知更改

            this.SetProperty(x => x.IsChecked);
        }

        /// <summary>
        /// 检查父类是否选 中
        /// 如果父类的子类中有一个和第一个子类的状态不一样父类ischecked为null
        /// </summary>
        private void CheckParentCheckState()
        {
            bool? _currentState = this.IsChecked;
            bool? _firstState = null;
            for (int i = 0; i < this.Children.Count(); i++)
            {
                bool? childrenState = this.Children[i].IsChecked;
                if (i == 0)
                {
                    _firstState = childrenState;
                }
                else if (_firstState != childrenState)
                {
                    _firstState = null;
                }
            }
            if (_firstState != null) _currentState = _firstState;
            SetIsChecked(_firstState, false, true);
        }

        #endregion

        #region 选中的行 IsSelected
        bool _isSelected;
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }
            set
            {
                _isSelected = value;
                this.SetProperty(x => x.IsChecked);
                if (_isSelected)
                {
                    SelectedTreeItem = this;
                    MessageBox.Show("选中的是" + SelectedTreeItem.Name);
                }
                else
                    SelectedTreeItem = null;
            }
        }
        #endregion

        #region 选中的数据
        public MyTree SelectedTreeItem
        {
            get;
            set;
        }
        #endregion

        #region 创建树

        public void CreateTreeWithChildre(MyTree children, bool? isChecked)
        {
            this.Children.Add(children);

            children.Parent = this;
            children.IsChecked = isChecked;
        }
        #endregion
    }
}