using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implict convert - Bİlinçsiz çevirme

            byte a = 5;
            sbyte b = 12;
            short c = 33;
            Console.WriteLine("implict Convert ornekleri");
            int d  = a + b + c;
            Console.WriteLine(d);

            long e = d;
            Console.WriteLine(e);   

            float f = e;
            Console.WriteLine(f);

            string st1 = " test";
            char   ch1 = 'K';
            object g = st1 + ch1 + d;
            Console.WriteLine(g);


            // Explict Convertion Bilinçi tip değişimi
            int x = 4;
            byte y = (byte)x;   
            Console.WriteLine(y);

            float x2 = 4.4f;
            byte y2 = (byte)x;
            Console.WriteLine(y2);

            // to string method ----------
            int x3 = 44;
            string dgr = x3.ToString();
            Console.WriteLine(dgr);


            // system convert 
            string str1 = "22", str2 = "11";
            int x5 = System.Convert.ToInt16(str1);
            c = System.Convert.ToInt16(str2);
            Console.WriteLine(x5);

            // Parse 
            string str3 = "343.34";

            float f3 = System.Convert.ToSingle(str3);
            Console.WriteLine(f3);
            float f4 = float.Parse(str3);
            Console.WriteLine(f4);

        }
    }
}
