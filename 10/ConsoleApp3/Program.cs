using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            ///////1////////////////
            Tovar e = new Tovar();
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add("Vadim");
            list.Add(e);
            list.Remove(e);
            Console.WriteLine("Всего элементов: " + list.Count);
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
            Poisk(2);
            void Poisk(object test)
            {
                int k = 0;
                foreach (object o in list)
                {
                    k++;
                    if (o.Equals(test))
                        Console.WriteLine("Есть такой");
                }
                if (k != list.Count)
                {
                    Console.WriteLine("такого нету");
                }
            }
            ///////////////////////////////
            Console.WriteLine("--------------------------------------------");
            Dictionary<int, string> countries = new Dictionary<int, string>();
            countries.Add(1, "Russia");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Del(countries, 2);

            void Del(Dictionary<int, string> test, int kol)
            {
                for (int i = 1; i <= kol; i++)
                {
                    countries.Remove(i);
                }
            }
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Queue<string> numbers = new Queue<string>();

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                numbers.Enqueue(keyValue.Value);
            }

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------------");
            Tovar n1 = new Tovar(1, "Bel", "LOC");
            Tovar n2 = new Tovar(2, "Rus", "SOC");
            Tovar n3 = new Tovar(3, "Col", "POC");
            Tovar n4 = new Tovar(4, "Eng", "TOY");
            Queue<Tovar> Persons = new Queue<Tovar>();
            Persons.Enqueue(n1);
            Persons.Enqueue(n2);
            Persons.Enqueue(n3);
            Persons.Enqueue(n4);
            foreach (var i in Persons)
            {
                Console.WriteLine(i);
            }
            создаем ObservableCollection
            ObservableCollection<Tovar> Tovars = new ObservableCollection<Tovar>
            {
            new Tovar { Proizv = "Evgeni"},
            new Tovar { Proizv = "Slava"},
            new Tovar { Proizv = "Boris"}
            };

            // указываем обработчик(будет вызываться если добавить, удалить, поменять элемент) 
            Tovars.CollectionChanged += Tovars_CollectionChanged;

            // добавляем элемент 
            Tovars.Add(new Tovar { Proizv = "Sergei" });

            // удаляем элемент 
            Tovars.RemoveAt(1);

            // заменяем элемент 
            Tovars[0] = new Tovar { Proizv = "Petia" };

            // показываем все элементы на экране 
            foreach (Tovar Tovar in Tovars)
            {
                Console.WriteLine(Tovar.Proizv);
            }
            Console.ReadLine();
        }
        private static void Tovars_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // срабатывает при добавлении элемента 
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Tovar newTovar = e.NewItems[0] as Tovar;
                Console.WriteLine("Добавлен новый объект: {0}", newTovar.Proizv);
            }

            // срабатывает при удалении элемента 
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Tovar oldTovar = e.OldItems[0] as Tovar;
                Console.WriteLine("Удален объект: {0}", oldTovar.Proizv);
            }

            // срабатывает при замене элемента 
            else if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Tovar replacedTovar = e.OldItems[0] as Tovar;
                Tovar replacingTovar = e.NewItems[0] as Tovar;
                Console.WriteLine("Объект {0} заменен объектом {1}", replacedTovar.Proizv, replacingTovar.Proizv);
            }
        }
    }
}
