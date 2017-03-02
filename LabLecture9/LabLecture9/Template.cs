using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Threading;

namespace LabLecture9
{
    abstract class Template
    {
        private double _time;
        private Thread _timer;
        private bool going = false;

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
            _timer = new Thread(Timer);
            going = true;
            _timer.Start();
        }

        private void Timer()
        {
            _time = 0;

            while (going)
            {
                _time += 1;
                Thread.Sleep(1);
            }
        }

        public void TimerStop()
        {
            going = false;
            _timer.Abort();
        }
    }
}
