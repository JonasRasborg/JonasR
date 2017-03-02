using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLecture9
{
    class ArrayGenerator
    {
        private int _size;
        private int _seed;
        private int[] _array;

        public ArrayGenerator(int size, int seed)
        {
            _size = size;
            _seed = seed;
        }

        public int[] GenerateArray()
        {
            Random rnd = new Random();
            _array = new int[_size];

            for (int i = 0; i < _size-1; i++)
            {
                _array[i] = rnd.Next(_seed);
            }

            return _array;
        }
    }
}
