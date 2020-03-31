using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Planshet : Tehnica 
    {
        public int SrocGdn = 4;
        public string Color;


        public Planshet(string color, int Id, string StranaProizv, string Proiz) : base(1, Id, StranaProizv, Proiz)
        {
            this.Color = color;
        }
        public Planshet(string color) : base(1)
        {
            this.Color = color;
        }
        public Planshet() : base(1)
        {
        }

        public override string ToString()
        {
            return $"Информация о товаре: Дата производства: {DateProizv}\n ID товора: {Id}\n Страна производитель: {StranaProizv}\n Прроизводитель: {Proizv}\n Вид товара: {VidTov}\n Срок годности: {SrocGdn}\n Цвет: {Color}\n Вид товара: Принтер\n";
        }
    }

}
