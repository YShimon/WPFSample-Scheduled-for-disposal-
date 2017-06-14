using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCommonModule.Views;

namespace WpfCommonModule
{
    public class WpfCommonModule : IModule
    {
        IRegionManager _regionManager;

        public WpfCommonModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(SampleView));
        }
    }
}
