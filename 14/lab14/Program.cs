using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;


namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {

            // объект для сериализации
            Point center = new Point(23, 0);
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(@"..\..\points.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, center);
            }

            // десериализация
            using (FileStream fs = new FileStream(@"..\..\points.dat", FileMode.OpenOrCreate))
            {
                Point newPoint = (Point)formatter.Deserialize(fs);
                Console.WriteLine($"X: {newPoint.x} , Y: {newPoint.y}");
            }






            ///////////////////////////////////////////////////////////////////////////
            Point person = new Point(23, 29);
            Point person2 = new Point(22, 25);
            Point[] people = new Point[] { person, person2 };

            // создаем объект SoapFormatter
            SoapFormatter formatter2 = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(@"..\..\points.soap", FileMode.OpenOrCreate))
            {
                formatter2.Serialize(fs, people);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация
            using (FileStream fs = new FileStream(@"..\..\points.soap", FileMode.OpenOrCreate))
            {
                Point[] newPeople = (Point[])formatter2.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                foreach (Point p in newPeople)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.x, p.y);
                }
            }



            string output = JsonConvert.SerializeObject(person);
            Point deserializedProduct = JsonConvert.DeserializeObject<Point>(output);



            // объект для сериализации
            Point dot = new Point(10, 100);
            // передаем в конструктор тип класса
            XmlSerializer xSer = new XmlSerializer(typeof(Point));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(@"..\..\points.xml", FileMode.OpenOrCreate))
            {
                xSer.Serialize(fs, dot);
            }
            // десериализация
            using (FileStream fs = new FileStream(@"..\..\points.xml", FileMode.OpenOrCreate))
            {
                Point newP = xSer.Deserialize(fs) as Point;
                Console.WriteLine(newP.ToString());
            }


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\points.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            // выбор всех дочерних узлов
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);
            //  Выберем все узлы<Point>:
            XmlNode childnode = xRoot.SelectSingleNode("//Point/x");
            if (childnode != null)
                Console.WriteLine(childnode.OuterXml);





            XDocument xdoc = XDocument.Load(@"..\..\phones.xml");
            var items = from xe in xdoc.Element("phones").Elements("phone")
                        where xe.Element("company").Value == "Samsung"
                        select new Phone
                        {
                            Name = xe.Attribute("name").Value,
                            Price = xe.Element("price").Value
                        };

            foreach (var item in items)
                Console.WriteLine($"{item.Name} - {item.Price}");
            Console.ReadKey();
        }
    }
}
