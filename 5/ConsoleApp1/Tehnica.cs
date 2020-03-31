using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tehnica : Tovar
    {
        //1-printer 2-scaner 3-computer 4-planshet
        public int VidTov;
        

        public void GetVidTiov()
        {
            Console.WriteLine("Код вида Техники: " + this.VidTov);
        }

        public Tehnica(int q, int Id, string StranaProizv, string Proiz) : base(Id, StranaProizv, Proiz)
        {
            this.VidTov = q;
            
        }
        public Tehnica(int q) : base()
        {
            this.VidTov = q;
        }

        public virtual void SayInfo()
        {
            Console.WriteLine("Это Класс Техника");
        }

        public override string ToString()
        {
            return $"Информация о товаре: Дата производства: {DateProizv}\n ID товора: {Id}\n Страна производитель: {StranaProizv}\n Прроизводитель: {Proizv}\n Вид товара: {VidTov}";
        }
    }
}
