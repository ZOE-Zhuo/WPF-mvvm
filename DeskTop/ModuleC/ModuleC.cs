
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleC
{
    public class ModuleC : Prism.Modularity.IModule
    {
        public ModuleC(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        private readonly IRegionViewRegistry regionViewRegistry;

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion(ModuleService.Module.ModuleC.ToString(), typeof(ModuleCPage));
        }
    }
}