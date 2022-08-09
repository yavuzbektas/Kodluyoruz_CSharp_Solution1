using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    Console.WriteLine("Lutfen sayı giriniz :");
            //    int deger = Convert.ToInt16(Console.ReadLine());
            //}
            //catch(Exception ex)  
            //{
            //    Console.WriteLine("Hata : " + ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("İslem tamam");
            //}


            
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("-2222222222");
                int a = int.Parse("tre");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Deger bos hatası");
                Console.WriteLine(ex);
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Deger cok buyuk hatası");
                Console.WriteLine(ex);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format hatası");
                Console.WriteLine(ex);

            }


        }
    }
}
