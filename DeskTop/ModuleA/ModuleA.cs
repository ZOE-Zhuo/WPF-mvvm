
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA
{
   
        public class ModuleA : IModule
        {

            public ModuleA(IRegionViewRegistry registry)
            {
                this.regionViewRegistry = registry;
            }

            private readonly IRegionViewRegistry regionViewRegistry;

            public void Initialize()
            {
                regionViewRegistry.RegisterViewWithRegion(ModuleService.Module.ModuleA.ToString(), typeof(Hello));
            }
        }
    }
