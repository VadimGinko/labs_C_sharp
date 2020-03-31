using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Set<T>
    {
        private List<T> Items = new List<T>();
        public int Count => Items.Count;
        public Set() { }
        public Set(T item)
        {
            Items.Add(item);
        }


        public void Set_Item(T item)
        {
            Items.Add(item);
        }

        public void Get_Item(T item)
        {
            Items.Remove(item);
        }

        public void PrintAll()
        {
            Console.WriteLine("Элементы множества: \n");
            foreach (var i in Items)
            {
                Console.WriteLine(i.GetType());
                Console.WriteLine(i);
            }
        }
        public void RRR()
        {
            Items.Sort();
        }
    }
}
