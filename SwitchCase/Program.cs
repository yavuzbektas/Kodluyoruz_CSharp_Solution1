using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mount = DateTime.Now.Month;

            switch (mount)
            {
                
                case 1:

                    Console.WriteLine("Ocay Ayındasınız ");
                    break;
                case 2:
                    Console.WriteLine("Subat Ayındasınız ");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız ");
                    break;
                case 8:
                    Console.WriteLine("Agustos Ayındasınız ");
                    break;
                default:
                    Console.WriteLine("Yanlış Veri Girişi  ");
                    break;
            }
        }
    }
}
