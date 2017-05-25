using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFSample_PrismUnity.Views;

namespace WPFSample_PrismUnity.Common
{
    public class SampleNavigator
    {
        static public void ShowDialog(int sampleWindowNumber)
        {
            WindowFactory.CreateWindow(sampleWindowNumber)?.ShowDialog();
        }
    }
}
