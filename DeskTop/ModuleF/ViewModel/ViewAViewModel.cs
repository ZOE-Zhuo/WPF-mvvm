using Microsoft.Practices.Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleF.ViewModel
{
    public   class ViewAViewModel
    {
        IRegionNavigationJournal journal;
        public DelegateCommand GoBackCommand { get; set; }

        public ViewAViewModel()
        {
            GoBackCommand = new DelegateCommand(GoBack);
        }

        void GoBack()
        {
            journal.GoBack();
        }
    }
}
