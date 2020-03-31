using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp7
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public User()
        {
            Name = "";
            Age = -1;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
        public void Payment(int hours, int perhour)
        {
            Console.WriteLine(hours * perhour);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Type tt = typeof(Int32);
            var bf = BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Static | BindingFlags.Instance;
            FieldInfo[] fi = tt.GetFields(bf);


            Reflector.ClassInfoInFile("ConsoleApp7.User");
            Reflector.Out_Constructors("ConsoleApp7.User");
            Reflector.Out_Interfaces("ConsoleApp7.User");
            Reflector.Metods_po_parametry("ConsoleApp7.User", typeof(int));
            Reflector.CallMethod("ConsoleApp7.exe", "Payment");
            Console.ReadLine();
        }
    }
}
