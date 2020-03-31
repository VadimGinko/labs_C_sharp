namespace ConsoleApp1
{
    class Scaner : Tehnica
    {
        public int SrocGdn = 2;
        public string Color;


        public Scaner(string color, int Id, string StranaProizv, string Proiz) : base(3, Id, StranaProizv, Proiz)
        {
            this.Color = color;
        }
        public Scaner(string color) : base(3)
        {
            this.Color = color;
        }
        public Scaner() : base(3)
        {
        }

        public override string ToString()
        {
            return $"Информация о товаре: Дата производства: {DateProizv}\n ID товора: {Id}\n Страна производитель: {StranaProizv}\n Прроизводитель: {Proizv}\n Вид товара: {VidTov}\n Срок годности: {SrocGdn}\n Цвет: {Color}\n Вид товара: Принтер\n";
        }
    }
}
