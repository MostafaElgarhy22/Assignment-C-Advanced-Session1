using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_Session1.Q_4
{
    public static class NumberUtils
    {
        public static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);  
                }
            }
            return evenNumbers;
        }
    }
}
