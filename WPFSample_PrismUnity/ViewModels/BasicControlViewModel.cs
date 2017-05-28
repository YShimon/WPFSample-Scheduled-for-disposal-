using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WPFSample_PrismUnity.ViewModels
{
    public class BasicControlViewModel : BindableBase
    {
        private Dictionary<string, string> ControlExplanations { get; set; } = new Dictionary<string, string>()
        {
            {
                "Button",
                "<Button Grid.Column=\"1\" Content=\"Button\" VerticalAlignment=\"Center\" Margin=\"10\" Width=\"100\" HorizontalAlignment=\"Left\"/>"
            },
        };

        public ReactiveProperty<string> ButtonControlExplanation { get; set; } = new ReactiveProperty<string>();

        public BasicControlViewModel()
        {
            InitReactiveProperties();
        }

        private void InitReactiveProperties()
        {
            ButtonControlExplanation.Value = ControlExplanations["Button"];
        }
    }
}
