using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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


            public void Add(T item)
            {
                foreach (var i in Items)
                {
                    if (i.Equals(item))
                    {
                        return;
                    }
                }
                Items.Add(item);
            }

            public void Remove(T item)
            {
                var k = Item();
                foreach (var i in k)
                {
                    if (i.Equals(item))
                    {
                        Items.Remove(item);
                        return;
                    }
                }
            }

            public void PrintAll()
            {
                Console.WriteLine("Состояние персонажей: \n\n");
                foreach (var i in Items)
                {
                    Console.WriteLine(i);
                }
            }

            public List<T> Item()
            {
                return Items;
            }

    }
}
