using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void addValue(T value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }
        public T first()
        {
            return _values[0];
        }
        public void print()
        {
            Console.Write("[");
            for(int i=0;i<_count -1;i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0) Console.Write(_values[_count-1]);
            Console.Write("]");
        }

    }
}
