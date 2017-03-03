using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LabLecture9
{
    class ArrayGenerator
    {
        private int _size;
        private int _seed;
        private int[] array;

        public ArrayGenerator(int size, int seed)
        {
            _size = size;
            _seed = seed;
        }

        public int[] GenerateArray()
        {
            Random rnd = new Random(_seed);
            array = new int[_size];

            for (int i = 0; i < _size-1; i++)
            {
                array[i] = rnd.Next(0, _size);
            }
            return array;
        }
    }
}
