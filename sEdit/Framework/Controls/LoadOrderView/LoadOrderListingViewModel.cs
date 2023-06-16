using Mutagen.Bethesda.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sEdit.Framework.Controls
{
    public class LoadOrderListingViewModel : BaseViewModel
    {
        public ModKey ModKey { get; set; }
        public bool Enabled { get; set; }
    }
}
