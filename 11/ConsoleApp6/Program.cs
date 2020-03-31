using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[] {"January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", "December"};

            #region 1
            Console.WriteLine("Введите длину месяца: ");
            int len = Convert.ToInt32(Console.ReadLine());
            IEnumerable q2 = months.Where(s => s.Length == len);
            foreach (var i in q2)
            {
                Console.WriteLine(i);
            }
            #endregion 1

            #region 2
            string[] wint = new string[] { "January", "February", "December" };
            string[] sum = new string[] { "June", "July", "August" };
            var result_wint = months.Intersect(wint);
            var result_sum = months.Intersect(sum);

            Console.WriteLine("\nЛетние месяцы:");

            foreach(var i in result_sum)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("\nЗимние месяцы:");

            foreach (var i in result_wint)
            {
                Console.WriteLine(i + " ");
            }
            #endregion 2

            #region 3
            Console.WriteLine();
            IEnumerable<string> t = months.OrderBy(i=>i);
            foreach(var y in t)
            {
                Console.WriteLine(y);
            }
            #endregion 3

            #region 4
            IEnumerable<string> q23 = months.Where(s => s.Contains('u')).Where(s => s.Length >= 4);
            #endregion 4

            #region 2.1
            Tovar elem = new Tovar(1233, "Japan", "integral");
            Tovar elem2 = new Tovar(1543, "Germany", "integral");
            Tovar elem3 = new Tovar(15423, "Russia", "integral");
            Tovar elem4 = new Tovar(15434, "Latvenia", "integral3");
            Tovar elem5 = new Tovar(16543, "Holand", "integral4");
            List<Tovar> q = new List<Tovar> {elem, elem2, elem3, elem4, elem5};
            Int32 n = 5;    
            Int32 m = 7;
            var e = q.Where(i => i.StranaProizv.Length == n).Select(i=>i);
            var e2 = q.Where(i => i.StranaProizv.Length == m).Select(i => i);
            var e3 = e.Union(e2);
            string str = "an";
            var e4 = q.Where(i => i.StranaProizv.Contains(str)).Select(i => i);
            var e5 = q.Max(i=>i.StranaProizv.Length);
            var e6 = q.FirstOrDefault(i => (i.StranaProizv.
            Contains('.') && (i.StranaProizv.Contains('?'))));
            var e7 = q.Min(i => i.StranaProizv.Length);

            int[] numbers = { 1, 2, 3, 4, 5 };

            int query = numbers.Aggregate((x, y) => x - y);
            var e10 = q.GroupBy(x => x.Proizv);
            foreach(var t1 in e10)
            {
                Console.WriteLine("Ключ: " + t1.Key + "Количество" + t1.Count());
            }
            var e9 = q.OrderBy(i => i.StranaProizv);
            #endregion 2.1

            #region 4
            var e8 = q.OrderBy(i => i.StranaProizv).Where(i => i.StranaProizv.Contains('u')).Where(i => i.StranaProizv.Length <= 8).LastOrDefault(i => i.StranaProizv.Length <= 7);
            #endregion 4




            string[] names = { "Анна", "Станислав", "Ольга", "Сева" };
            int[] key = { 1, 4, 5, 7 };
            var sometype = names
            .Join(
            key, // внутренняя
            w => w.Length, // внешний ключ выбора
            OO => OO, // внутренний ключ выбора
            (w, OO) => new // результат
            {
                id = w,
                name = string.Format("{0} ", OO),
            });
            foreach (var item in sometype)
                Console.WriteLine(item);


            Console.ReadKey();
        }
    }
}
