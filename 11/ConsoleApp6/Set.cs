using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Tovar
    {
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

      

        new string ToString()
        {
            return $"Информация о товаре: Дата производства: ID товора: {Id}\n";
        }
    }
}
