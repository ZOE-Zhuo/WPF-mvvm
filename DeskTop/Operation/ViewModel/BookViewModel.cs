using Operation.Model;
using Operation.Service;
using Operation.View;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Operation.ViewModel
{

    public class BookViewModel : NotificationObject
    {
        //public ObservableCollection<Model.Book> Items { get; set; } = new ObservableCollection<Model.Book>();

        ObservableCollection<Model.Book> myItems = new ObservableCollection<Model.Book>();
        public ObservableCollection<Model.Book> mylist
        {

            get { return myItems; }
            set
            {
                myItems = value;
                RaisePropertyChanged("mylist");
            }
        }
        //public ICommand EditCommand { get; set; }
        private bool _IsSelectAll = false;
        public bool IsSelectAll
        {
            get { return _IsSelectAll; }
            set
            {
                _IsSelectAll = value;
                RaisePropertyChanged("IsSelectAll");
            }
        }
        private ICommand _ForWardCommand;
        public ICommand ForWardComand
        {
            get
            {
                return _ForWardCommand ?? (_ForWardCommand = new Prism.Commands.DelegateCommand<object>(forward));
            }
        }

        private void forward(object obj)
        {
            throw new NotImplementedException();
        }

        IRegionNavigationJournal _journal;
        
        
        //private void forward(object obj)
        //{
        //    _journal = NavigationContext.NavigationService.Journal;
        //}

        private ICommand _AddCommand;
        
        public DelegateCommand PopCommand { set; get; }
        public InteractionRequest<ICustomNotification> CustomNotificationRequest { get; set; }
      
        public ICommand AddCommand
        {
            get
            {
                return _AddCommand ?? (_AddCommand = new DelegateCommand(Add));
            }
        }
        public Command<Window> Addommand {
            set; get; }

        private void Add()
        {
            AddEdit windows1 = new AddEdit();
          //  Application.Current.MainWindow.ShowDialog<AddEditViewModel>(windows1);

            windows1.ShowDialog();

            var vm = windows1.DataContext as AddEditViewModel;
            Model.Book b1 = new Model.Book();
            if (vm.IsOk)
            {
                b1 = vm.Book;

            }
            mylist.Add(b1);
        }
        private ICommand _EditCanComand;
        public ICommand EditCanComamnd {
            get
            {
                return _EditCanComand ?? (_EditCanComand = new Prism.Commands.DelegateCommand<Canvas>(Edit));
            }
        }
        //public void Add(object obj)

        //{
        //    AddEdit windows1 = new AddEdit();
        //    windows1.Show();

        //}

        private ICommand _SelectAllCommand;
        public ICommand SelectAllCommand
        {
            get
            {
                return _SelectAllCommand ?? (_SelectAllCommand = new Prism.Commands.DelegateCommand<object>(SelectAll));
            }
        }


        public void SelectAll(object id)
        {
            foreach (var item in myItems)
            {
                item.IsSelected = IsSelectAll;
            }
        }

        private ICommand _SelectCommand;
        public ICommand SelectCommand
        {
            get
            {
                return _SelectCommand ?? (_SelectCommand = new Service.DelegateCommand<int>(Select));
            }
        }

        public void Select(int id)
        {
            Model.Book md = myItems.Where(p => p.BookId == id).FirstOrDefault();
            if (md != null)
            {
                if (!md.IsSelected && IsSelectAll)
                {
                    IsSelectAll = false;
                }
                else if (md.IsSelected && !IsSelectAll)
                {
                    foreach (var item in myItems)
                    {
                        if (!item.IsSelected) return;
                    }
                    IsSelectAll = true;
                }
            }
        }

        public bool SelectValidate(bool onlyOne = false)
        {
            if (this.myItems.Count(p => p.IsSelected) < 1)
            {
                MessageBox.Show("未勾选数据！");
                return false;
            }

            if (onlyOne)
            {
                if (this.myItems.Count(p => p.IsSelected) > 1)
                {
                    MessageBox.Show("只能勾选一条数据！");
                    return false;
                }
            }

            return true;
        }
        private ICommand _EditCommand;
        public ICommand EditCommand => _EditCommand ?? (_EditCommand = new Service.DelegateCommand<Canvas>(G =>
                                                     {
                                                         TextBox TB = G.FindName("txtBookName") as TextBox;
                                                         
                                                         Canvas C = G.FindName("textCanvas") as Canvas;
                                                         C.Visibility = C.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
                                                        
                                                     }));

        //private void EditCan(object obj)
        //{
        //    TextBox n1=
        //}

        public void Edit(object obj = null)
        {
            if (!SelectValidate(true)) return;

            Model.Book model = null;


            bool hasSelect = false;
            //获取选中的数据
            foreach (var v in myItems)
            {
                if (v.IsSelected) { model = v; hasSelect = true; break; }
            }
            if (!hasSelect)
            {
                MessageBox.Show("请选择修改项", "警告");
                return;
            }

            MessageBox.Show("选中 " + model.BookName);

        }
        public BookViewModel()
        {

            for (int i = 0; i < 100; i++)
            {
                mylist.Add(new Model.Book { BookId = i, BookName = "书", BookAuthor = "sanzang", BookType = "jiaoxue", Publisher = "人民出版社" });
            }
           
            //Addommand = new Command<Window>(Add);
            //EditCommand = new DelegateCommand(Edit);
            //EditCommand = new DelegateCommand(delete);
        }
        string _msessage = "点击按钮显示弹窗";

        public string Message
        {
            get { return _msessage; }
            set { _msessage = value;
                RaisePropertyChanged("Message");
            }
        }
    
        

        private ICommand _DelCommand;
        public ICommand DelCommand
        {
            get
            {
                return _DelCommand ?? (_DelCommand = new Service.DelegateCommand<object>(Del));
            }
        }
        public void Del(object obj=null)
        {
            
            if (!SelectValidate()) return;
                                                                    
                    mylist.Remove(mylist.Single(p => p.IsSelected == true));                            
        }

     private bool _IsSelected = false;
        public bool IsSelected
        {
            get
            {
                return _IsSelected;
            }
            set
            {
                _IsSelected = value;
                this.RaisePropertyChanged("IsSelected");
            }
        }



    }
}