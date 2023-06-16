using Mutagen.Bethesda;
using Mutagen.Bethesda.Environments;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Assets;
using sEdit.Framework;
using Sextant;
using Splat;
using System.Reactive.Disposables;

namespace sEdit.ViewModels
{
    public class MainViewModel : NavigableViewModel
    {
        public object LoadOrder { get; }
        public ILinkCache LinkCache { get; }
        public ModKey MK { get; set; }
        public MainViewModel() : base()
        {
            var gameRelease = SkyrimRelease.SkyrimSE;
            var env = GameEnvironment.Typical.Skyrim(gameRelease, LinkCachePreferences.OnlyIdentifiers());
            LinkCache = env.LinkCache;
            LoadOrder = env.LoadOrder;
            MK = Skyrim.ModKey;
        }
    }
}
