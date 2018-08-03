using System;
using System.Collections.Generic;
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

namespace ModuleG
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Students> infos = new ObservableCollection<Students>() {
            new Students(){ Id=1, Age=11, Name="Tom"},
            new Students(){ Id=2, Age=12, Name="Darren"},
            new Students(){ Id=3, Age=13, Name="Jacky"},
            new Students(){ Id=4, Age=14, Name="Andy"}
            };

        public  MainWindow()
        {
            InitializeComponent();

            this.lbStudent.ItemsSource = infos;

            this.txtStudentId.SetBinding(TextBox.TextProperty, new Binding("SelectedItem.Id") { Source = lbStudent });
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            infos[1] = new Students() { Id = 4, Age = 14, Name = "这是一个集合改变" };
            infos[2].Name = "这是一个属性改变";
        }

        public class Students
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}