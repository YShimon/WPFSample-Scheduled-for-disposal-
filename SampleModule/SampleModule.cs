using Prism.Modularity;
using Prism.Regions;
using SampleModule.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModule
{
    public class SampleModule : IModule
    {
        IRegionManager _regionManager;

        public SampleModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(SampleMainView));
        }
    }
}
