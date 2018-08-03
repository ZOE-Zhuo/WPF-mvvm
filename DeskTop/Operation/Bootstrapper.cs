using Operation.View;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Operation
{
  public  class Bootstrapper:UnityBootstrapper
    {

        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Shell>();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();

           App.Current.MainWindow = (Window)Shell;
           App.Current.MainWindow.Show();

        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();


            Container.RegisterTypeForNavigation<PersonDetail>("Per");
        }

    }
}
