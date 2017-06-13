using HelloWorldModule.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        //[Dependency]
        //public IUnityContainer Container { get; set; }

        private readonly IRegionManager RegionManager;
        public HelloWorldModule(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
        }

        public void Initialize()
        {
            //this.Container.RegisterType<MessageProvider>(new ContainerControlledLifetimeManager());
            //this.Container.RegisterType<object, HelloWorld>(nameof(HelloWorld));

            //this.RegionManager.RequestNavigate("ContentRegion", nameof(HelloWorld));
            RegionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.HelloWorldView));
        }
    }
}
