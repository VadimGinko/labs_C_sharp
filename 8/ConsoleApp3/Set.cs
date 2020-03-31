using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp3
{
    [Serializable]
    public class Set<T> : Tinterface<T> where T: Tovar
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

        public List<T> Item()
        {
            return Items;
        }

        public void Save(string CurrentFile)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(CurrentFile, FileMode.OpenOrCreate))
            {

                bf.Serialize(fs, Items);
                fs.Close();
            }


        }
        // записываем текст в поток 
        public void Upload(string CurrentFile)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(CurrentFile, FileMode.OpenOrCreate))
                {
                List <T> deser = (List <T>)bf.Deserialize(fs);
                    foreach (T p in deser)
                    {
                        if (p == null)
                            continue;
                        this.Add(p);

                    }
                    fs.Close();
                }
            }

    }
}
