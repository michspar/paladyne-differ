using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paladyne_differ
{
    public interface IDataAdapter
    {
        Control GetSettingsControl();
        event EventHandler<DataTableEventArgs> SettingsApplied;
    }

    public class DataTableEventArgs : EventArgs
    {
        public DataTable Table { get; private set; }

        public DataTableEventArgs(DataTable table)
        {
            Table = table;
        }
    }
}
