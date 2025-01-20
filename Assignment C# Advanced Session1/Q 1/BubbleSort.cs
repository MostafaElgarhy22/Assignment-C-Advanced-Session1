using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_Session1.Q_1
{
    public static class Helper<T> where T : IComparable<T>
    {
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    public static class BubbleSortt
    {
        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr is null || arr.Length == 0)
                return;

            for (int i = 0; i < arr.Length; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Helper<T>.Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
            }

        }
    }
}
