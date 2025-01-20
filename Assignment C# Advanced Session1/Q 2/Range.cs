using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_Session1.Q_2
{
    public class Range<T> where T : IComparable<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }

        public Range(T min, T max)
        {
            Max = max;
            Min = min;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Max) >= 0 && value.CompareTo(Min) <= 0;
        }
        public T Length()
        {
            dynamic max = Max;  // عملنا هنا ديناميك علشان فيه عملية طرح
            dynamic min = Min;
            return max - min;
        }
    }
}
