using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace sEdit.Framework
{
    public class BaseView<TViewModel> : ReactiveUserControl<TViewModel> where TViewModel : BaseViewModel
    {
        public BaseView() : base() { }
    }
}
