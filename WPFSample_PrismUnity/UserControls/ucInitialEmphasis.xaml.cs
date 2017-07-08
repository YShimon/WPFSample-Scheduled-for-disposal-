using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Controls;

namespace WPFSample_PrismUnity.UserControls
{
    /// <summary>
    /// ucInitialEmphasis.xaml の相互作用ロジック
    /// </summary>
    public partial class ucInitialEmphasis : UserControl
    {
        // 1. 依存プロパティの作成
        public static readonly DependencyProperty InputTextProperty =
            DependencyProperty.Register(
                "InputText", // プロパティ名を指定
                typeof(string),  // プロパティの型を指定
                typeof(ucInitialEmphasis),// プロパティを所有する型を指定
                new PropertyMetadata(
                    string.Empty,
                    new PropertyChangedCallback((sender, e) =>
                    {
                        (sender as ucInitialEmphasis).OnLocalePropertyChanged(sender, e);
                    })));

        public string InputText
        {
            get { return (string)this.GetValue(ucInitialEmphasis.InputTextProperty); }
            set { this.SetValue(ucInitialEmphasis.InputTextProperty, value); }
        }

        private void OnLocalePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            this.InitialWord.Text = e.NewValue.ToString().Substring(0, 1);
            this.RestWord.Text = e.NewValue.ToString().Substring(1, e.NewValue.ToString().Length - 1);
        }

        public ucInitialEmphasis()
        {
            InitializeComponent();
        }
    }
}
