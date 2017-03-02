using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLecture9
{
    class QuickSorter : Template, ISuperSorter
    {
        private int _l;
        private int _r;

        public override int[] StartSort(int[] data)
        {
            _l = 0;
            _r = data.Length - 1;
            return QuickSort(data, _l, _r);
        }

        public int[] QuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    Exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                QuickSort(data, l, j);
            if (i < r)
                QuickSort(data, i, r);

           return data;
        }
    }
}
