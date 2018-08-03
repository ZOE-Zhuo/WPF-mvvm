using Operation.Model;
using Operation.Service;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows;

namespace Operation.ViewModel
{
    public class AddEditViewModel : NotificationObject
    {
        private bool _IsOk;
        
        public bool IsOk
        {
            get
            {
                return _IsOk;
            }
            set
            {
                _IsOk = value;
                RaisePropertyChanged("IsOk");

            }
        }
        public Command<System.Windows.Window> SaveCommand
        {
            set;
            get;
        }
        public AddEditViewModel()
        {
            //SaveCommand = new Command<System.Windows.Window>(Window =>{ Window.Close(); });
          SaveCommand=new  Command<System.Windows.Window>(Ok);
            var vm = this.Book;
        }    
        public  void Ok(System.Windows.Window  window)
        {
            IsOk = true;
            var m = window.DataContext;

            window.Close();
         

        }


        private Book _Book;
        public event PropertyChangedEventHandler PropertyChanged;
        public Book Book
        {
            get
            {
                return _Book;
            }
            set
            {
                _Book = value;
                RaisePropertyChanged("Book");

            }
        }
   
       
      

        public void IsOK()
        {
            _IsOk = true;

        }

    }
}
