using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Radiant : Person
    {
        public Radiant(int hp, string name) : base(hp, name)
        {
            this.Rasa = "Radiant";
        }

    }
}
