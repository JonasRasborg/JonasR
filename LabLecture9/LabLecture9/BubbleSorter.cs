using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LabLecture9
{
    class BubbleSorter : Template, ISuperSorter
    {
        public DTO<int> Sort(DTO<int> data)
        {
            int i, j;
            int N = data.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }

            return data;
        }
    }
}
