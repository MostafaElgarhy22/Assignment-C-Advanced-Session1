using Assignment_C__Advanced_Session1.Q_1;

namespace Assignment_C__Advanced_Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1
            int[] Numbers = { 100, 56, 22, 17, 13, 90, 99 };

            Helper<int>.BubbleSort(Numbers);


            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }

            #endregion

        }
    }
}
