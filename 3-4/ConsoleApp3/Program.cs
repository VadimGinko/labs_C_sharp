using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            Set qw = new Set();
            Set q1 = new Set();
            Set q2 = new Set();
            Console.WriteLine(qw.owner.id);
            Console.WriteLine(qw.creationDate.ToString());          
            qw.Add("first");
            qw.Add("second");
            qw.Add("third");
            qw.Add("third");
            q1.Add("third");
            q2.Add("third");
            q2.Add("wqewqe");
            qw = qw + "Q";
            string[] mas = q1 % q2;
            qw.PrintAll();
            qw.Poriadok();
            qw.PrintAll();
            q1.PrintAll();
            if (q1 > q2)
            {
                Console.WriteLine("первое подмножество второго");
            }
            else
            {
                Console.WriteLine("это ложь, первое не подмножество второго");
            }

            if (q1 < q2)
            {
                Console.WriteLine("второе подмножество первого");
            }
            else
            {
                Console.WriteLine("это ложь, второе не подмножество первого");
            }


            if (q1 == q2)
            {
                Console.WriteLine("множества равны");
            }
            else
            {
                Console.WriteLine("множества не равны");
            }

            if (q1 != q2)
            {
                Console.WriteLine("множества не равны");
            }
            else
            {
                Console.WriteLine("множества равны");
            }
            qw.Smaller_String();
            StaticOperation.GetSum(qw);
            StaticOperation.GetCount(qw);
            StaticOperation.GetRaznic(qw);
            StaticOperation.LenStr("qwer");
            string l = Console.ReadLine();
        }
    }

  
}