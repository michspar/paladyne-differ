using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paladyne_differ
{
    class CompareProgressEventArgs : EventArgs
    {
        public CompareProgressEventArgs(int progress)
        {
            Progress = progress;
        }

        public int Progress { get; private set; }
    }
}
