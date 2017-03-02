using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLecture9
{
    class QuickSorter : Template, ISuperSorter
    {

        public int[] Sort(int[] data)
        {
            return QuickSort(data, l, r);
        }
        public int[] QuickSort(int[] data, int l, int r)
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
