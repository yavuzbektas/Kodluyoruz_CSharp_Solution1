using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_and_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());


            if (N % 2 == 1 || (N > 5 && N < 21))

            { Console.WriteLine("Weird"); }

            else
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
