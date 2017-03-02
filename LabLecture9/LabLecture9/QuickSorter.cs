using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLecture9
{
    class QuickSorter : Template
    {
        public int[] Sort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l-1;
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
                    exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                Sort(data, l, j);
            if (i < r)
                Sort(data, i, r);

           return data;
        }
    }
}
