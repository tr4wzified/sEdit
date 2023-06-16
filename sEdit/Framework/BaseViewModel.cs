using ReactiveUI;
using Sextant;
using Splat;

namespace sEdit.Framework
{
    public abstract class BaseViewModel : ReactiveObject, IViewModel
    {
        protected readonly IViewStackService ViewStackService;
        public BaseViewModel()
        {
            ViewStackService = Locator.Current.GetService<IViewStackService>()!;
        }
        public string Id => GetType().Name;
    }
}
