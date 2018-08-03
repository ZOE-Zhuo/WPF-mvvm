using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;
using System.Windows.Controls;

namespace DeskTop
{
    public   class Bootstrapper: UnityBootstrapper
    {
       
       
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
           
        }

        //protected override void InitializeShell()
        //{
        //    Application.Current.MainWindow.Show();
        //}
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(ModuleE.ModuleE));
            moduleCatalog.AddModule(typeof(ModuleA.ModuleA));
            moduleCatalog.AddModule(typeof(ModuleB.Moduleb));
            moduleCatalog.AddModule(typeof(ModuleC.ModuleC));
            moduleCatalog.AddModule(typeof(ModuleD.Moduled));
            //moduleCatalog.AddModule(typeof(ModuleF.ViewModel.ModuleFViewModel));

        }
    }
}
