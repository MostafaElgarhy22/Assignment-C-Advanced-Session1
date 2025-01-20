using Assignment_C__Advanced_Session1.Q_1;
using Assignment_C__Advanced_Session1.Q_2;

namespace Assignment_C__Advanced_Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1
            //int[] Numbers = { 100, 56, 22, 17, 13, 90, 99 };

            //Helper<int>.BubbleSort(Numbers);


            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Q 2

            Console.WriteLine("Enter max and min values: ");

            double max = double.Parse(Console.ReadLine());  
            double min = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value to check if its in the range : ");
            double value = double.Parse(Console.ReadLine());

            var range = new Range<double>(max, min);

            Console.WriteLine($"{range.IsInRange(value)}");
            Console.WriteLine($"Length of range is : {range.Length()}");
            #endregion
        }
    }
}
