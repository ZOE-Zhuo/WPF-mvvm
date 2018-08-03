using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleD
{
    public class PersonDataHelper
    {
        public static ObservableCollection<Person> GetPersons()
        {
            ObservableCollection<Person> samplePersons = new ObservableCollection<Person>();
            samplePersons.Add(new Person() { Name = "张三", Age = 33 });
            samplePersons.Add(new Person() { Name = "王五", Age = 22 });
            samplePersons.Add(new Person() { Name = "李四", Age = 35 });
            samplePersons.Add(new Person() { Name = "LearningHard", Age = 27 });
            return samplePersons;
        }
    }

    public class Person
    {
        public string Name;
        public int Age;
            
    }
}