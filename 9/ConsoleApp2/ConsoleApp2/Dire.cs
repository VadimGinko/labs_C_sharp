using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Dire : Person
    {
        public Dire(int hp,string name):base(hp, name)
        {
            this.Rasa = "Dire";
        }

    }
}
