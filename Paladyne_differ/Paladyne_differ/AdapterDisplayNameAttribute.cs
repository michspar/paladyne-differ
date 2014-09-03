using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladyne_differ
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AdapterDisplayNameAttribute : Attribute
    {
        public readonly string Name;

        public AdapterDisplayNameAttribute(string name)
        {
            Name = name;
        }
    }
}
