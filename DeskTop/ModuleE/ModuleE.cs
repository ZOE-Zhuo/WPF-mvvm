using ModuleE.View;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleE
{
   
        public class ModuleE : Prism.Modularity.IModule
        {
            public ModuleE(IRegionViewRegistry registry)
            {
                this.regionViewRegistry = registry;
            }

            private readonly IRegionViewRegistry regionViewRegistry;

            public void Initialize()
            {
                regionViewRegistry.RegisterViewWithRegion(ModuleService.Module.ModuleE.ToString(), typeof(ModuleEPage));
            }
        }
    }