using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using static TelerikDemo.PersonCollection;

namespace TelerikDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        PersonCollection pc = new PersonCollection();

        void MainPage_Loaded(object sender, RoutedEventArgs e)

        {

            pc.LstData.Add(new Person() { Name = "张三", Age = 1 });

            pc.LstData.Add(new Person() { Name = "李四", Age = 2 });

            this.DataContext = pc;

            //this.grd1.ItemsSource = pc;

        }





        private void btnAdd_Click(object sender, RoutedEventArgs e)

        {

            pc.LstData.Add(new Person() { });

        }

        private void btnSub_Click(object sender, RoutedEventArgs e)

        {

            var p = (sender as RadButton).DataContext as Person;

            pc.LstData.Remove(p);

        }
        private void btnSave_Click(object sender, RoutedEventArgs e)

        {
            foreach (var item in this.pc.LstData)

            {

                MessageBox.Show(string.Format("Name:{0},Age:{1}", item.Name, item.Age));

            }

        }

        private void GridViewColumn_MouseEnter(object sender, MouseEventArgs e)
        {
            var m = (sender as Button).DataContext is Person;
            MessageBox.Show(m.ToString());
        }
    }
    public class PersonCollection

    {

        private ObservableCollection<Person> lstData = new ObservableCollection<Person>();
        public ObservableCollection<Person> LstData

        {

            get { return lstData; }

            set { lstData = value; }

        }
        private ObservableCollection<Person> _currentItem = new ObservableCollection<Person>();
        public ObservableCollection<Person> CurrentItem
        {
            get
            {
                return _currentItem;
            }
            set
            {
                _currentItem = value;
            }


        }
        public class Person : INotifyPropertyChanged

        {

            public event PropertyChangedEventHandler PropertyChanged;

            private string _name = "";
            public string Name

            {

                get { return _name; }

                set

                {

                    _name = value;

                    if (PropertyChanged != null)

                    {

                        PropertyChanged(this, new PropertyChangedEventArgs("Name"));

                    }

                }

            }
            private int _age = 0;
            public int Age

            {

                get { return _age; }

                set

                {

                    _age = value;

                    if (PropertyChanged != null)

                    {

                        PropertyChanged(this, new PropertyChangedEventArgs("Age"));

                    }

                }

            }

        }
    }
}

