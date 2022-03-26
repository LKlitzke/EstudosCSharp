using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class CalculationService
    {
        public T max<T>(List<T> list) where T : IComparable
        {
            T max = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) max = list[i];
            }
            return max;
        }
    }
}
