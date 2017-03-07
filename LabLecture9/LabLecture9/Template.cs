using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Threading;
using System.Diagnostics;

namespace LabLecture9
{
    abstract class Template
    {
        private Stopwatch _stopWatch;
        private double _time;

        public Tuple<int[], double> Sort(int[] data)
        {
            TimerStart();
            int[] _data = StartSort(data);
            TimerStop();
            return Tuple.Create(_data, _time);
        }

        public virtual int[] StartSort(int[] data)
        {
            return data;
        }

        public int[] Exchange(int[] data, int i, int j)
        {
            int _i = data[i];
            int _j = data[j];

            data[i] = _j; data[j] = _i;

            return data;
        }

        public void TimerStart()
        {
            _stopWatch = new Stopwatch();
            _stopWatch.Start();
        }

        public void TimerStop()
        {
            _stopWatch.Stop();
            _time = _stopWatch.ElapsedMilliseconds;
        }
    }
}
