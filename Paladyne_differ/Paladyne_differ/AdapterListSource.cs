using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Paladyne_differ
{
    class AdapterListSource : IListSource
    {
        public bool ContainsListCollection
        {
            get { return true; }
        }

        static Tuple<TypeInfo, string>[] adapters;

        static AdapterListSource()
        {
            var baseDir = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

            adapters = Directory.GetFiles(baseDir, "*.dll").
                SelectMany(
                    file => System.Reflection.Assembly.LoadFrom(file).DefinedTypes.
                    Where(type => type.ImplementedInterfaces.Contains(typeof(IDataAdapter)) && type.GetCustomAttribute<AdapterDisplayNameAttribute>() != null)).
                Select( typeInfo => new Tuple<TypeInfo, string>(typeInfo, typeInfo.GetCustomAttribute<AdapterDisplayNameAttribute>().Name)).ToArray();
        }

        public System.Collections.IList GetList()
        {
            return adapters.Select(adapter => adapter.Item2).ToArray();
        }
    }
}
