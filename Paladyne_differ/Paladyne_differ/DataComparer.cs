using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public ComparationResult Compare(int keyColumnLeft, int[] columnsLeft, int keyColumnRight, int[] columnsRight, BackgroundWorker bg)
        {
            var n = dataTableLeft.Rows.Count;
            var rval = new ComparationResult();

            for (int iLeft = 0, iProgress = 0; iLeft < dataTableLeft.Rows.Count && !bg.CancellationPending; iLeft++, iProgress++)
            {
                for (var iRight = 0; iRight < dataTableRight.Rows.Count && !bg.CancellationPending; iRight++)
                    if (string.Format("{0}", dataTableLeft.Rows[iLeft][keyColumnLeft]) == string.Format("{0}", dataTableRight.Rows[iRight][keyColumnRight]))
                    {
                        var right = dataTableRight.Rows[iRight];
                        var left = dataTableLeft.Rows[iLeft];

                        if (RowsAreMatching(left, right, columnsLeft, columnsRight))
                            rval.Matched.Add(left.ItemArray.Select(item => string.Format("{0}", item)).ToArray());
                        else
                        {
                            var matchedRows = new KeyValuePair<string[], string[]>(SelectColumns(left, keyColumnLeft, columnsLeft), SelectColumns(right, keyColumnRight, columnsRight));

                            rval.PartiallyMatched.Add(matchedRows);
                        }

                        dataTableLeft.Rows.RemoveAt(iLeft--);
                        dataTableRight.Rows.RemoveAt(iRight);

                        break;
                    }

                OnProgressChanged(iProgress * 100 / n);
            }

            dataTableLeft.
            Rows.
            OfType<DataRow>().
            ToList().
            ForEach(row => rval.UniqueLeft.Add(SelectColumns(row, keyColumnLeft, columnsLeft)));

            dataTableRight.
            Rows.
            OfType<DataRow>().
            ToList().
            ForEach(row => rval.UniqueRight.Add(SelectColumns(row, keyColumnLeft, columnsLeft)));

            OnProgressChanged(bg.CancellationPending ? 0 : 100);

            return rval;
        }

        private string[] SelectColumns(DataRow left, int keyCol, int[] columnsLeft)
        {
            return new [] { string.Format("{0}", left[keyCol]) }.Concat(columnsLeft.Select(col => string.Format("{0}", left[col]))).ToArray();
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
