using Operation.Model;
using Operation.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation.ViewModel
{
    public class PersonDetailVieswModel : NotificationObject
    {

        Person _selectedPerson;

        public Person SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                RaisePropertyChanged("SelectedPerson");

            }
        }

        public PersonDetailVieswModel()
        {
        }
    }
}