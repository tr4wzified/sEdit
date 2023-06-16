using Sextant;
using Splat;
using System;
using System.Reactive;
using System.Reactive.Linq;

namespace sEdit.Framework
{
    public abstract class NavigableViewModel : BaseViewModel, INavigable {
        protected readonly IViewStackService ViewStackService;
        protected string? Parameter;
        public NavigableViewModel() : base()
        {
            ViewStackService = Locator.Current.GetService<IViewStackService>()!;
        }

        public virtual IObservable<Unit> WhenNavigatedFrom(INavigationParameter parameter) => Observable.Return(Unit.Default);

        public virtual IObservable<Unit> WhenNavigatedTo(INavigationParameter parameter)
        {
            parameter.TryGetValue("parameter", out string? param);
            Parameter = param;
            return Observable.Return(Unit.Default);
        }

        public virtual IObservable<Unit> WhenNavigatingTo(INavigationParameter parameter)
        {
            return Observable.Return(Unit.Default);
        }
    }
}
