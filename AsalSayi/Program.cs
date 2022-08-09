using System;

namespace AsalSayi
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }


                }
                return result;
            }
            if (IsPrimeNumber(1533571))
            {
                Console.WriteLine("Asaldır");
            }
            else
            {
                Console.WriteLine("Asal Değildir");
            }
            //string charx = "0";

            //var deger = Convert.ToInt32(charx);
            //while (charx != "q" || charx != null)
            //{
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine(" Lütfen bir sayı giriniz : ");
            //    charx = Console.ReadLine();
            //    deger = Convert.ToInt16(charx);
            //    if (deger == 2)
            //    {
            //        Console.WriteLine(charx);
            //        Console.WriteLine("Asal sayıdır ");
            //        continue;
            //    }
            //    if (deger == 5)
            //    {
            //        Console.WriteLine(charx);
            //        Console.WriteLine("Asal sayıdır ");
            //        continue;
            //    }
            //    if (deger == 7)
            //    {
            //        Console.WriteLine(charx);
            //        Console.WriteLine("Asal sayıdır ");
            //        continue;
            //    }

            //    if (deger % 2 == 0 || deger % 3 == 0 || deger % 5 == 0 || deger % 7 == 0)
            //    {
            //        Console.WriteLine(charx);
            //        Console.WriteLine("Asal Sayı değildir ");
            //        continue;
            //    }
            //    else 
            //    {
            //        Console.WriteLine(charx);
            //        Console.WriteLine("Asal sayıdır ");
            //        continue;
            //    }



            //}
            //Console.WriteLine("Programdan Çıkılıyor");


        }
    }
}
