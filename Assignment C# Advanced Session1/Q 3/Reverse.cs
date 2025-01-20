using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_Session1.Q_3
{
    public static class ListReverser      
    {
        public static void Reverse(List<int> list)
        {
            int start = 0;                    // اول عنصر في الليست
            int end = list.Count - 1;         // اخر عنصر في الليست من الاخر بنعمل بينهم تبديل

            while (start < end)
            {
                int temp = list[start];
                list[start] = list[end];
                list[end] = temp;
                start++;
                end--;
            }
        }
    }
}
