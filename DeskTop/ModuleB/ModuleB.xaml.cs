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

namespace ModuleB
{
    /// <summary>
    /// ModuleB.xaml 的交互逻辑
    /// </summary>
    public partial class ModuleB : UserControl
    {
        ObservableCollection<Student> persons = new ObservableCollection<Student>()
        {
            new Student() { Name ="LearningHard", Age=25},
            new Student() { Name ="HelloWorld", Age=22}
        };
        public ModuleB()
        {
            InitializeComponent();
            lstPerson.ItemsSource = persons;

        }

        private void ChangeBrushToYellow_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["RedBrush"] = new SolidColorBrush(Colors.Yellow);
            ;
        }
        public class Student : INotifyPropertyChanged
        {
            public string ID { get { return Guid.NewGuid().ToString(); } }

            public string Name { get; set; }

            public int Age { get; set; }


            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}