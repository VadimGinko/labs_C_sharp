using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Tovar : Date, Interface1, IComparable
    {
        public override string DateProizv
        {
            get;
            set;
        }
        protected int Id;
        public string StranaProizv;
        public string Proizv;

        public int ID
        {
            get
            {
                return Id;
            }
            set
            {
                if (value < 0 && value > 1000000)
                    Console.WriteLine("Некорейный Id товара");
                else
                {
                    Id = value;
                }
            }
        }

        
        public string STRANAPROIZV
        {
            get
            {
                return StranaProizv;
            }
            set
            {
                if (value.Length > 30)
                    Console.WriteLine("Некоректное казвание страны");
                else
                {
                    StranaProizv = value;
                }
            }
        }

        public string PROIZV
        {
            get
            {
                return Proizv;
            }
            set
            {
                if (value.Length > 100)
                    Console.WriteLine("Некоректное имя производителя");
                else
                {
                    Proizv = value;
                }
            }
        }
        public Tovar()
        {
            this.ID = -1;
            this.STRANAPROIZV = "None";
            this.PROIZV = "None";
        }

        public Tovar(int Id, string StranaProizv, string Proizv)
        {
            this.ID = Id;
            this.STRANAPROIZV = StranaProizv;
            this.PROIZV = Proizv;
        }

        public void GetId()
        {
            Console.WriteLine("ID товара: " + Id);
        }

        public void GetStrana()
        {
            Console.WriteLine("Страна производителя товара: " + StranaProizv);
        }

        public void GetProizvod()
        {
            Console.WriteLine("Имя производителя товара: " + StranaProizv);
        }

        public override void EnterDate(string value)
        {
            DateProizv = value;
        }
        void Interface1.GEtDate()
        {
            Console.WriteLine("Дата производства нашего товара: " + DateProizv);
        }

        public override void GEtDate()
        {
            Console.WriteLine("Дата производства товара: " + DateProizv);
        }


        public int CompareTo(object obj)
        {
            Tovar p = obj as Tovar;


            if (p != null)
            {
                if (this.Id < p.Id)
                    return -1;
                else if (this.Id > p.Id)
                    return 1;
                else
                    return 0;
            }
            else
            {
                throw new Exception("Параметр типа должен быть типа Tovar");
            }

            }
        public override string ToString()
        {
            return $"Информация о товаре: Дата производства: {DateProizv}\n ID товора: {Id}\n Страна производитель: {StranaProizv}\n Прроизводитель: {Proizv}\n";
        }
    }
}
