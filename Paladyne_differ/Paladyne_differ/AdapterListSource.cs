using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paladyne_differ
{
    class AdapterListSource : IListSource
    {
        public bool ContainsListCollection
        {
            get { return true; }
        }

        IDataAdapter[] adapters;

        public AdapterListSource()
        {
            var baseDir = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

            adapters = Directory.GetFiles(baseDir, "*.dll").
                SelectMany(
                    file => System.Reflection.Assembly.LoadFrom(file).DefinedTypes.
                    Where(type => type.ImplementedInterfaces.Contains(typeof(IDataAdapter)))).
                Select(typeInfo => Activator.CreateInstance(typeInfo.UnderlyingSystemType) as IDataAdapter).ToArray();
        }

        public System.Collections.IList GetList()
        {           
            return adapters;
        }
    }
}
