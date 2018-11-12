using System;

namespace Codechef_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            input = Console.ReadLine();

            string[]    arr      = input.Split(' ');
            int         withdraw = int.Parse(arr[0]);
            double      total    = double.Parse(arr[1]);

            if (withdraw % 5 == 0 &&
                withdraw + 0.5 <= total)
            {
                total = total - withdraw - 0.5;
                Console.WriteLine(string.Format("{0:0.00}", total));
            }
            else
            {
                Console.WriteLine(total);
            }

            Console.ReadLine();
        }
    }
}
