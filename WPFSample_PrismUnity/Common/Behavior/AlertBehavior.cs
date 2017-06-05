using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace WPFSample_PrismUnity.Common.Behavior
{
    public class AlertBehavior : Behavior<Button>
    {
        #region メッセージプロパティ
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Message.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(AlertBehavior), new UIPropertyMetadata(null));
        #endregion

        public AlertBehavior()
        {
        }

        // 要素にアタッチされたときの処理。大体イベントハンドラの登録処理をここでやる
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.Click += Alert;
        }

        // 要素にデタッチされたときの処理。大体イベントハンドラの登録解除をここでやる
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.Click -= Alert;
        }

        // メッセージが入力されていたらメッセージボックスを出す
        private void Alert(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Message))
            {
                return;
            }

            MessageBox.Show(this.Message);
        }
    }
}
