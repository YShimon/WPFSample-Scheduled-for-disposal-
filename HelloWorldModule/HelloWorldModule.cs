using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using HelloWorldModule.Models;
using HelloWorldModule.Views;

namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        //[Dependency]
        //public IUnityContainer Container { get; set; }
        
        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public HelloWorldModule(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
        }

        public void Initialize()
        {
            //this.Container.RegisterType<MessageProvider>(new ContainerControlledLifetimeManager());
            //this.Container.RegisterType<object, HelloWorld>(nameof(HelloWorld));

            //this.RegionManager.RequestNavigate("ContentRegion", nameof(HelloWorld));
            RegionManager.RegisterViewWithRegion("ContentRegion", typeof(HelloWorld));
        }
    }
}
