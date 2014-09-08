using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paladyne_differ
{
    public interface ISettingsChandedInformer
    {
        event EventHandler SettingsChanged;
    }
}
