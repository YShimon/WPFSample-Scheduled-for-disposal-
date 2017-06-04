using System.Windows;
using System.Windows.Controls;

namespace WPFSample_PrismUnity.UserControls
{
    /// <summary>
    /// Interaction logic for ucDependencyPropertySample
    /// </summary>
    public partial class ucDependencyPropertySample : UserControl
    {
        // 1. 依存プロパティの作成
        public static readonly DependencyProperty LocaleProperty =
            DependencyProperty.Register(
                "Locale", // プロパティ名を指定
                typeof(string),  // プロパティの型を指定
                typeof(ucDependencyPropertySample),// プロパティを所有する型を指定
                new PropertyMetadata(
                    string.Empty,
                    new PropertyChangedCallback((sender, e) =>
                    {
                        (sender as ucDependencyPropertySample).OnLocalePropertyChanged(sender, e);
                    })));

        public string Locale
        {
            get { return (string)this.GetValue(ucDependencyPropertySample.LocaleProperty); }
            set { this.SetValue(ucDependencyPropertySample.LocaleProperty, value); }
        }

        private void OnLocalePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var message = string.Empty;

            switch (e.NewValue.ToString())
            {
                case "ja":
                    message = "こんにちは";
                    break;
                case "en":
                    message = "Hello";
                    break;
                default:
                    break;
            }

            this.txt.Text = message;
        }

        public ucDependencyPropertySample()
        {
            InitializeComponent();
        }
    }
}
