using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;


namespace ConsoleApp1
{
    abstract class Print
    {
        public static void iAmPrinting(Date test )
        {
            Console.WriteLine(test.ToString());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Printer elem = new Printer("зелёный", 1233, "Belarus", "integral");
                Console.WriteLine(elem.ToString());
                Computer elem2 = new Computer("красный", 1543, "Belarus", "integral");
                Planshet elem3 = new Planshet("синий", 1343, "Belarus", "integral");
                //структура
                Tovar.User Src;
                Src.age = 2;
                Src.name = "Vadim";
                Src.DisplayInfo();
                //перечисление
                Tovar.Days days;
                days = Tovar.Days.Monday;
                Console.WriteLine("Понедельник: " + days);
                Console.WriteLine("Понедельник: " + (int)days);
                Set<Tovar> qw = new Set<Tovar>();
                qw.Set_Item(elem2);
                qw.Set_Item(elem);
                qw.Set_Item(elem3);
                qw.PrintAll();
                qw.RRR();
                qw.PrintAll();
                ///////1///////
                //int g = 5;
                //int t = g / 0;
                ///////////////

                ///////2///////
                //int[] mass = { 2, 4, 5 };
                //int y = mass[3];
                ///////////////

                ///////3///////
                //Planshet elem4 = new Planshet("зелёный", 1343, "Belarus", "integral");
                ///////////////

                ///////4///////
                //Planshet elem5 = new Planshet("белый", 1113, "Belarus", "integral");
                ///////////////

                //int[] aa = null;
                //Debug.Assert(aa != null, "values array cannot be null");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
                //throw;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (ColorException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (IdException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally");
                Console.ReadLine();
            }
        }
    }
}
