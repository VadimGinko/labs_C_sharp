using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<Tovar> qw = new Set<Tovar>();
            Printer elem = new Printer("чёрный", 1233, "Belarus", "integral");
            Tehnica elem2 = new Tehnica(4);
            Printer elem3 = new Printer("белый", 1763, "Huawei", "China");
            Printer elem4 = new Printer("зедёный", 1823, "Xiomi", "China");
            qw.Add(elem);
            qw.Add(elem2);
            qw.Add(elem3);
            qw.Add(elem4);
            qw.PrintAll();


            //qw.Save(@"D:\class.dat");
            //qw.Upload(@"..\..\class.dat");
            string l = Console.ReadLine();
        }
    }

  
}