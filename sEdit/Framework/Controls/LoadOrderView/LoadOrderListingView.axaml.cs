using Mutagen.Bethesda.Plugins;
using ReactiveUI;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace sEdit.Framework.Controls
{
    public partial class LoadOrderListingView : BaseView<LoadOrderListingViewModel> {
        public LoadOrderListingView() : base()
        {
            InitializeComponent();
            this.WhenActivated(disposable =>
            {
                this.WhenAnyValue(x => x.ViewModel!.ModKey)
                    .Select(m => (object)m)
                    .BindTo(this, x => x.CheckBox.Content)
                    .DisposeWith(disposable);
            });
        }
    }
}
