using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface Tinterface<T>
    {
        void Add(T item);
        void Remove(T item);
        void PrintAll();
    }
}
