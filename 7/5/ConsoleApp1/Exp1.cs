using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PlanshetException : Exception
    {
        public PlanshetException(string message) : base(message)
        {
            Console.WriteLine("Ошибка в классе Планшет");
        }
    }
}
