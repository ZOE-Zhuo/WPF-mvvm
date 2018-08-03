using Operation.ViewModel;
using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation.Service
{
    public class CustomNotification : Confirmation, ICustomNotification
    {
        public List<string> Items { get; set; }
        public string SelectedItem { get; set; }

        public CustomNotification()
        {
            Items = new List<string>();
        }
    }
}