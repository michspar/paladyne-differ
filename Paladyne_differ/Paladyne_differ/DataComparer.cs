using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Paladyne_differ
{
    class DataComparer
    {
        private DataTable dataTableLeft;
        private DataTable dataTableRight;

        public DataComparer(DataTable dataTableLeft, DataTable dataTableRight)
        {
            this.dataTableLeft = dataTableLeft.Copy();
            this.dataTableRight = dataTableRight.Copy();
        }

        public event EventHandler<CompareProgressEventArgs> ProgressChanged;

        void OnProgressChanged(int progress)
        {
            var tmp = ProgressChanged;

            if (tmp != null)
                tmp(this, new CompareProgressEventArgs(progress));
        }

        public void Compare(int keyColumnLeft, int[] columnsLeft, int keyColumnRight, int[] columnsRight)
        {
            var n = dataTableLeft.Rows.Count;
            var matched = new List<string[]>();
            var partiallyMatched = new List<string[][]>();

            for (var iLeft = 0; iLeft < n; iLeft++)
            {
                for (var iRight = 0; iRight < dataTableRight.Rows.Count; iRight++)
                    if (string.Format("{0}", dataTableLeft.Rows[iLeft][keyColumnLeft]) == string.Format("{0}", dataTableRight.Rows[iRight][keyColumnRight]))
                    {
                        var right = dataTableRight.Rows[iRight];
                        var left = dataTableLeft.Rows[iLeft];

                        if (RowsAreMatching(left, right, columnsLeft, columnsRight))
                            matched.Add(left.ItemArray.Select(item => string.Format("{0}", item)).ToArray());
                        else
                        {
                            var matchedRows = new[] {
                                left.ItemArray.Select(item => string.Format("{0}", item)).ToArray(), right.ItemArray.Select(item => string.Format("{0}", item)).ToArray() };

                            partiallyMatched.Add(matchedRows);
                        }

                        dataTableLeft.Rows.RemoveAt(iLeft--);
                        dataTableRight.Rows.RemoveAt(iRight);

                        break;
                    }

                OnProgressChanged(iLeft * 100 / n);

                n = dataTableLeft.Rows.Count;
            }

            var unique = dataTableLeft.Rows.OfType<DataRow>().Zip(dataTableRight.Rows.OfType<DataRow>(), (a, b) => new[] { a.ItemArray, b.ItemArray }).ToList();

            OnProgressChanged(100);
        }

        private bool RowsAreMatching(DataRow left, DataRow right, int[] columnsLeft, int[] columnsRight)
        {
            if (columnsLeft.Length != columnsRight.Length)
                return false;

            for (var i = 0; i < columnsLeft.Length; i++)
                if (string.Format("{0}", left[columnsLeft[i]]) != string.Format("{0}", right[columnsRight[i]]))
                    return false;

            return true;
        }
    }
}
