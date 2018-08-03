
using Operation.ViewModel;
using System;
using System.Collections.ObjectModel;
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

namespace Operation.View
{
    /// <summary>
    /// Emp.xaml 的交互逻辑
    /// </summary>
    public partial class Book : UserControl
    {
        public Book()
        {
            InitializeComponent();

            DataContext = new BookViewModel();

        }

        public bool IsSelected { get; internal set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();


            window.Source = new Uri("AddEdit.xaml", UriKind.Relative);


            window.Show();

        }

        private void BookGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }



   
}
