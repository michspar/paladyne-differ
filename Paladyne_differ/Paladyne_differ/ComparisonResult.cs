using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paladyne_differ
{
    class ComparationResult
    {
        public List<string[]> Matched = new List<string[]>();
        public List<KeyValuePair<string[], string[]>> PartiallyMatched = new List<KeyValuePair<string[], string[]>>();
        public List<string[]> UniqueLeft = new List<string[]>();
        public List<string[]> UniqueRight = new List<string[]>();
    }
}
