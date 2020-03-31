using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Date
    {
        public abstract string DateProizv { get; set; }
        public abstract void EnterDate(string value);
        public abstract void GEtDate();
    }
}
 