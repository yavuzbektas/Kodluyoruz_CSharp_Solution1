using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            bool c = a > b;
            c = a < b;
            c = a == b;
            c= a !=b;
            c= a>=b;
            c=a<= b;    
            Console.WriteLine(c);

            int say1 = 15;
            int say2 = 5;
            int sonuc = 0;

            sonuc = say1 / say2;
            sonuc = say1 * say2;
            sonuc = say1 + say2;
            sonuc = say1 - say2;
            sonuc = say1 % say2;
            sonuc = say1 ++;
            Console.WriteLine(sonuc);
        }
    }
}
