using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LabLecture9
{
    abstract class Template
    {
        public int[] Exchange(int[] data, int i, int j)
        {
            int _i = data[i];
            int _j = data[j];

            data[i] = _j; data[j] = _i;

            return data;
        }
    }
}
