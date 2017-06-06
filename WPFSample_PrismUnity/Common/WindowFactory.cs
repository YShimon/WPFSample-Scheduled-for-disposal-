using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFSample_PrismUnity.Views;

namespace WPFSample_PrismUnity.Common
{
    public class WindowFactory
    {
        static public Window CreateWindow(int viewId)
        {
            Window _window = null;
            switch (viewId)
            {
                case 0: _window = new BasicControl(); break;
                case 1: _window = new StyleSample(); break;
                case 3: _window = new BehaviorSample(); break;
                case 4: _window = new DependencyPropertySample(); break;
                default: break;
            }
            return _window;
        }
    }
}
