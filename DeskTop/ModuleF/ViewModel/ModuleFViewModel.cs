using Microsoft.Practices.Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleF.ViewModel

{
    public class ModuleFViewModel : Prism.Modularity.IModule
    {
        private IRegionManager _regionManager;
        public ModuleFViewModel(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
           

        }
       
        public DelegateCommand GoForwardCommand { get; set; }
        

        private readonly IRegionViewRegistry regionViewRegistry;

        public void Initialize()
        {
            
            regionViewRegistry.RegisterViewWithRegion(ModuleService.Module.ModuleF.ToString(), typeof(View.ModuleF));
            

        }
        public ModuleFViewModel()
        {
            this.GoForwardCommand = new DelegateCommand(GoForward);
        }

        private void GoForward()
        {
            _regionManager.RequestNavigate("ModuleF", "ViewA");
            
        }

       
    }
}