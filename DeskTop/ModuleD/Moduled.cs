using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleD
{
    public class Moduled : IModule
    {
        public Moduled(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        private readonly IRegionViewRegistry regionViewRegistry;

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion(ModuleService.Module.ModuleD.ToString(), typeof(ModuleD));
        }
    }
}