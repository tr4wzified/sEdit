using Avalonia.ReactiveUI;
using sEdit.Framework;
using sEdit.ViewModels;

namespace sEdit.Views
{
    public partial class MainView : BaseView<MainViewModel>
    {
        public MainView() : base()
        {
            InitializeComponent();
        }
    }
}
