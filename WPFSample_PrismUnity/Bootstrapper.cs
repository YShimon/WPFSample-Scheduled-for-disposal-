using Microsoft.Practices.Unity;
using Prism.Unity;
using WPFSample_PrismUnity.Views;
using System.Windows;

namespace WPFSample_PrismUnity
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
