using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class StaticOperation
    {
        public static void GetSum(Set Items)
        {
            int sum = 0;
            foreach(var i in Items.Item())
            {
                sum += i.Length;
            }
            Console.WriteLine("Сумма длин строк элемента: "+sum);
        }

        public static void GetCount(Set Items)
        {
            int count = 0;
            foreach (var i in Items.Item())
            {
                count ++;
            }
            Console.WriteLine("Колличество элементов: " + count);
        }

        public static void GetRaznic(Set Items)
        {
            int min = 11111110;
            int max = 0;
            foreach (var i in Items.Item())
            {
                if (i.Length > max)
                {
                    max = i.Length;
                }
                if (i.Length < min)
                {
                    min = i.Length;
                }
            }
            int razn = max - min;
            Console.WriteLine("Разница между максимальным и минимальным: " + razn);
        }

        public static void Smaller_String(this Set Items)
        {

            string min = Items.Item()[0];
            foreach (var i in Items.Item())
            {
                string I = Convert.ToString(i);
                if (I.Length <= min.Length)
                {
                    min = I;
                }
            }
            Console.WriteLine("Самая короткая строка: " + min);
        }
        public static void Poriadok(this Set Items)
        {
            for (int t = 0; t < Items.Count; t++)
            {
                for (int y = t + 1; y < Items.Count; y++)
                {
                    if (Items.Item()[t].Length < Items.Item()[y].Length)
                    {
                        string Prom = Items.Item()[t];
                        Items.Item()[t] = Items.Item()[y];
                        Items.Item()[y] = Prom;
                    }
                }
            }
        }

        public static void LenStr(this string Item)
        {
            Console.WriteLine("Длина строки: " + Item.Length);
        }
    }
}
