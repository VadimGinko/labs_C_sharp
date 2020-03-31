using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Printer elem = new Printer("чёрный",1233,"Belarus","integral");
            Console.WriteLine(elem.ToString());
            Computer elem2 = new Computer("красный", 1543, "Belarus", "integral");
            Planshet elem3 = new Planshet("Синий", 1343, "Belarus", "integral");
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
            Set <Tovar> qw = new Set<Tovar>();
            qw.Set_Item(elem2);
            qw.Set_Item(elem);
            qw.Set_Item(elem3);
            qw.PrintAll();
            qw.RRR();
            qw.PrintAll();
            Console.ReadLine();
        }
    }
}
