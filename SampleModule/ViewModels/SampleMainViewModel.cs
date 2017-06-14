using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleModule.ViewModels
{
    public class SampleMainViewModel : BindableBase
    {
        public class SampleInfo
        {
            public int Id { get; set; }

            public string Explanation { get; set; }
        }

        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ReactiveCollection<SampleInfo> Items { get; set; } = new ReactiveCollection<SampleInfo>()
        {
            new SampleInfo { Id = 0, Explanation = "コントロールの基本", },
            new SampleInfo { Id = 1, Explanation = "コントロールのスタイル", },
            new SampleInfo { Id = 2, Explanation = "画面遷移", },
            new SampleInfo { Id = 3, Explanation = "Behaviour", },
            new SampleInfo { Id = 4, Explanation = "依存関係プロパティ", },
        };

        /// <summary>
        /// サンプル画面へ遷移
        /// </summary>
        public ReactiveCommand ExecuteSample { get; private set; } = new ReactiveCommand();

        public MainWindowViewModel()
        {
            ExecuteSample.Subscribe(InvokeSampleCommand);
        }

        /// <summary>
        /// 画面遷移アクション
        /// </summary>
        Action<object> InvokeSampleCommand = (object x) =>
        {
            Console.WriteLine($"DoSample : {((SampleInfo)x).Id} , {((SampleInfo)x).Explanation}");
            SampleNavigator.ShowDialog(((SampleInfo)x).Id);
        };
    }
    }
}
