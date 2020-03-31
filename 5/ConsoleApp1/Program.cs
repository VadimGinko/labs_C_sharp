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
            Console.WriteLine(test);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer elem = new Printer("чёрный",1233,"Belarus","integral");
            Console.WriteLine(elem);
            Printer elem2 = new Printer("красный", 1543, "Belarus", "integral");
            elem2.EnterDate("10.08.2011");
            elem2.GEtDate() ;
            Print.iAmPrinting(elem2) ;
            if (elem2 is Interface1)
            {
                Interface1 face_perem = (Interface1)elem2;
                face_perem.GEtDate();
            }
            Tehnica q1 = elem2;
            Print.iAmPrinting(q1);
            Print.iAmPrinting(elem2);
            Console.ReadLine();
        }
    }
}
