
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleB
{
    public class Moduleb : IModule
    {
        public Moduleb(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        private readonly IRegionViewRegistry regionViewRegistry;

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion(ModuleService.Module.ModuleB.ToString(), typeof(ModuleB));
        }
    }
}