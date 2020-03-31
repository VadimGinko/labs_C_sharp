using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -15;
            uint unum = 15;
            float f = 1.23f;
            bool b = true;
            string name = "Vadim";
            char sname = 'Y';

            object o = num;//упоковка в кучу
            int j = (int)o;

            double first = num;
            long second = num;
            float third;
            third = (float)num;

            string result1 = String.Format("My name is {0}", name);
            Console.WriteLine(result1);

            string result2 = $"My name is {name}"; //интерполяция - $
            Console.WriteLine(result2);

            Console.WriteLine(f.ToString());
            Console.WriteLine(sname.GetHashCode());
            Console.WriteLine(unum.GetType());
            Console.WriteLine(num.Equals(unum)); 

            string im = "Vadim";
            string fam = "Ginko";

            Console.WriteLine(im.CompareTo(im));  

            if (im.Contains('a'))
            {
                Console.WriteLine("im содержит 'a' ");
            }
            else
            {
                Console.WriteLine("im  не содержит 'a' ");
            }

            Console.WriteLine(fam.Substring(0, fam.Length - 2)); // обрезает символы (то, что оставляем)

            Console.WriteLine(im.Insert(2, fam));

            Console.WriteLine(im.Replace("Vadim", "fff"));

            //string value = "privet";
            string str = "";
            string str0 = null;
            if (String.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is null or empty.");
            }
            else
            {
                Console.WriteLine("String is neither null nor empty.");
            }
            if (String.IsNullOrEmpty(str0))
            {
                Console.WriteLine("String is null or empty.");
            }
            else
            {
                Console.WriteLine("String is neither null nor empty.");
            }

            //7------------------------
            var variable = "";
            variable = Convert.ToString(5);

            //8------------------------
            int? n = null;
            Nullable<int> n2 = null;


            (int a, int b) tuple1 = (5, 7);
            int func(int one, int two)
            {
                return one + two;
            }
            Console.WriteLine(func(tuple1.a, tuple1.b));

            (int int1, char char1, string string1) kortezh = (5, 'c', "string1");
            Console.WriteLine($"{kortezh.int1} {kortezh.char1} {kortezh.string1}");
            var tuple = (5, 10);
            (_, var y3) = tuple;
            var person2 = (var: 4, var2: 5);


            localfun_1();
            void localfun_1()
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);// -2147483647
            }

            //localfun_2();
            //void localfun_2()
            //{
            //    checked
            //    {
            //        int val = int.MaxValue;
            //        Console.WriteLine(val + 2);
            //    }
            //}

            int state = 3;
            using (Example qwe = new Example(state))
            {
                Console.WriteLine(qwe.GetState());
            }
            Console.Read();
        }


    }

 
    class Example : IDisposable
    {
        private readonly int _state;

        public Example(int state)
        {
            _state = state;
        }

        public int GetState() => _state;

        public void Dispose()
        {

        }
    }
}