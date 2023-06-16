using ReactiveUI;
using Sextant;

namespace sEdit.Framework
{
    public abstract class BaseViewModel : ReactiveObject, IViewModel
    {
        public BaseViewModel()
        {
        }
        public string Id => GetType().Name;
    }
}
