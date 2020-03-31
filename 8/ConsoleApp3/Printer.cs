using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [Serializable]
    public class Printer : Tehnica
    {
        public int SrocGdn = 5;
        public string Color;


        public Printer(string color, int Id, string StranaProizv, string Proiz) : base(4, Id, StranaProizv, Proiz)
        {
            this.Color = color;
        }
        public Printer(string color) : base(4)
        {
            this.Color = color;
        }
        public Printer() : base(4)
        {
        }

        public override int GetHashCode()
        {
            Random rnd = new Random();
            int value = rnd.Next(100, 10000);
            return this.SrocGdn * value;
        }



        override public void SayInfo()
        {
            Console.WriteLine("Это Класс Принтер");
        }

        public override string ToString()
        {
            return $"\nИнформация о товаре:\n ID товора: {Id}\n Страна производитель: {StranaProizv}\n Прроизводитель: {Proizv}\n Вид товара: {VidTov}\n Срок годности: {SrocGdn}\n Цвет: {Color}\n Вид товара: Принтер\n";
        }

    }

}
