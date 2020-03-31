using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer : Tehnica
    {
        public int SrocGdn = 6;
        public string Color;


        public Computer(string color, int Id, string StranaProizv, string Proiz) : base(2, Id, StranaProizv, Proiz)
        {
            this.Color = color;
        }
        public Computer(string color) : base(2)
        {
            this.Color = color;
        }
        public Computer() : base(2)
        {
        }

        public override string ToString()
        {
            return $"Информация о товаре: Дата производства: {DateProizv}\n ID товора: {Id}\n Страна производитель: {StranaProizv}\n Прроизводитель: {Proizv}\n Вид товара: {VidTov}\n Срок годности: {SrocGdn}\n Цвет: {Color}\n Вид товара: Принтер\n";
        }
    }
}
