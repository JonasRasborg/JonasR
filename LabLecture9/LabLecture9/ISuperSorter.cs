﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LabLecture9
{
    interface ISuperSorter
    {
       Tuple<int[], double> Sort(int[] data); //Returns array and sorting-time
    }
}
