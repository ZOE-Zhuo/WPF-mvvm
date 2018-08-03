using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ModuleE.View;
using Prism.Interactivity.InteractionRequest;
using System.ComponentModel;

namespace ModuleE.ViewModel
{
    public class ModuleEPageViewModel : BindableBase, System.ComponentModel.INotifyPropertyChanged
    {
        private string textmessage;
       


        public ModuleEPageViewModel()
        {
            this.AssignCommand = new DelegateCommand(Assign);          
        }
        private void Assign()
        {
            this.textmessage = "藏三";
            TextMessage = textmessage;

        }
        public string TextMessage
        {
            get
            {
                return this.textmessage;
            }
            set
            {
                NotifyPropertyChanged(TextMessage);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public DelegateCommand AssignCommand { get; private set; }

        
    }

}