using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Set
    {

        public readonly Owner owner = new Owner(32123, "Vadim", "BSTU");
        public readonly Date creationDate = new Date();

        public class Owner
        {
            public readonly int id;
            public readonly string name;
            public readonly string organisation;

            public Owner(int id, string name, string organisation)
            {
                this.id = id;
                this.name = name;
                this.organisation = organisation;
            }
            public void Getinfo()
            {
                Console.WriteLine($"ID: {id} Name: {name} Organization: {organisation}");
            }
        }

        public class Date
        {
            DateTime dateTime = DateTime.Now;

            public override String ToString()
            {
                return dateTime.ToShortDateString();
            }
        }

        private List<string> Items = new List<string>();
        public int Count => Items.Count;
        public Set() { }
        public Set(string item)
        {
            Items.Add(item);
        }


        public void Add(string item)
        {
            foreach (var i in Items)
            {
                if (i == item)
                {
                    return;
                }
            }
            Items.Add(item);
        }

        public void Remove(string item)
        {
            foreach (var i in Items)
            {
                if (i.Equals(item))
                {
                    Items.Remove(item);
                }
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("Элементы множества: \n");
            foreach (var i in Items)
            {
                Console.WriteLine(i);
            }
        }

        public List<string> Item()
        {
            return Items;
        }

        public static Set operator +(Set c1, string R)
        {
            c1.Add(R);
            return c1;
        }

        public static bool operator -(Set c1, string R)
        {
            c1.Remove(R);
            return true;
        }

        public static bool operator ==(Set c1, Set c2)
        {
            int count = 0;
            foreach (var i in c1.Items)
            {
                foreach (var y in c2.Items)
                {
                    if (i == y)
                    {
                        count++;
                    }
                }
            }
            if (count == c1.Count && count == c2.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator !=(Set c1, Set c2)
        {
            int count = 0;
            foreach (var i in c1.Items)
            {
                foreach (var y in c2.Items)
                {
                    if (i == y)
                    {
                        count++;
                    }
                }
            }
            if (count == c1.Count && count == c2.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >(Set c1, Set c2)
        {
            int count = 0;
            foreach (var i in c1.Items)
            {
                foreach (var y in c2.Items)
                {
                    if (i == y)
                    {
                        count++;
                    }
                }
            }
            if (count == c1.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Set c1, Set c2)
        {
            int count = 0;
            foreach (var i in c2.Items)
            {
                foreach (var y in c1.Items)
                {
                    if (i == y)
                    {
                        count++;
                    }
                }
            }
            if (count == c2.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static string[] operator %(Set c1, Set c2)
        {
            string[] mas = new string [100];
            int num = 0;
            foreach (var i in c1.Items)
            {
                foreach (var y in c2.Items)
                {
                    if (i == y)
                    {
                        mas[num] = i;
                        num++;
                    }
                }
            }
            return mas;
        }

    }
}
