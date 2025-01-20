using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_Session1.Q_6
{
    public class First_unrepeated_char
    {
        public static int FirstChar<T>(List<T> indexes)
        {
            Dictionary<T, int> frequency = new Dictionary<T, int>();

            foreach (T item in indexes)
            {
                if (frequency.ContainsKey(item))
                    frequency[item]++;
                else
                    frequency[item] = 1; 
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                if (frequency[indexes[i]] == 1)
                {
                    return i;  
                }
            }
            return -1; 
        }
    }
}
