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
        DTO<int> Sort(DTO<int> data);
    }
}
