using Operation.Model;
using Operation.Service;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation.ViewModel
{
    public class NavigationViewModel:NotificationObject
    {
        ObservableCollection<Person> _people = new ObservableCollection<Person>();
        IRegionManager _regionManager;

        public ObservableCollection<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                RaisePropertyChanged("People");
            }
        }

        public DelegateCommand<Person> PersonSelectedCommand { get; set; }
        public NavigationViewModel()
        {
            People.Add(new Person { FirstName = "A", LastName = "B", });
            People.Add(new Person { FirstName = "B", LastName = "A" });
            PersonSelectedCommand = new DelegateCommand<Person>(Select);
            
        }

       
    

        private void Select(Person obj)
        {
            if (obj != null)
            {

                //_regionManager.RequestNavigate("ContentRegion", new Uri());
                _regionManager.RequestNavigate("ContentRegion", "Per");
              
               
            }
        }
    }
}
