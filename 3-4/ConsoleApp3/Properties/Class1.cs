using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    partial class pen
    {
        public static void testMethod2(ref int param)
        {
            param = 10;
            param++;
            Console.WriteLine("Значение переменной param в методе testMethod = {0}", param);
        }

        public static void testMethod(out int param)
        {
            param = 10;
            param++;
            Console.WriteLine("Значение переменной param в методе testMethod = {0}", param);
        }
    }
}
