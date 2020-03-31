using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void AccountHandler(Person a, Person b, int sum, Set<Person> qw);
    class Event
    {
        public event AccountHandler Heal;
        public event AccountHandler Kick;
        public void Register_Heal(AccountHandler e)
        {
            Heal += e;
        }
        public void Go_Heal(Person a, Person b, int sum, Set<Person> qw)
        {
            Heal.Invoke(a, b, sum, qw);
        }
        public void Register_Kick(AccountHandler e)
        {
            Kick += e;
        }
        public void Go_Kick(Person a, Person b, int sum, Set<Person> qw)
        {
            Kick.Invoke(a, b, sum, qw);
        }
    }
    public class Person
    {


        public Person(int hp, string name)
        {
            this.Hp = hp;
            this.Name = name;
        }
        public Person()
        {
        }
        public int Hp;
        public string Rasa;
        public string Name;
        public void Add_Hp(Person a,Person b, int sum, Set<Person> qw)
        {
            if ((a.Rasa == "Radiant" && b.Rasa == "Radiant") || (a.Rasa == "Dire" && b.Rasa == "Dire"))
            {
                a.Hp += sum;
            }
        }
        //второй совершает действие
        public void Add_Hp_INFO(Person a, Person b, int sum, Set<Person> qw)
        {
            if ((a.Rasa == "Radiant" && b.Rasa == "Radiant") || (a.Rasa == "Dire" && b.Rasa == "Dire"))
            {
                Console.WriteLine($"Персонажу {a.Name} было вылечено персонажем {b.Name} : " + sum + "HP");
            }
            else
            {
                Console.WriteLine("Уровень жизни без изменений, вы не можете лечить соперника");
            }
        }
        public void Remove_Hp(Person a, Person b, int sum, Set<Person> qw)
        {
            if ((a.Rasa == "Radiant" && b.Rasa == "Dire") || (a.Rasa == "Dire" && b.Rasa == "Radiant"))
            {
                a.Hp -= sum;
            }
        }
        //второй совершает действие
        public void Remove_Hp_INFO(Person a, Person b, int sum, Set<Person> qw)
        {
            if(a.Hp <= 0)
            {
                qw.Remove(a);
                Console.WriteLine($"Персонаж {a.Name} погиб\n");
            }
            if ((a.Rasa == "Radiant" && b.Rasa == "Dire") || (a.Rasa == "Dire" && b.Rasa == "Radiant"))
            {
                Console.WriteLine($"Персонажу {a.Name} было снято персонажем {b.Name} : " + sum + "HP");
            }
            else
            {
                Console.WriteLine("Уровень жизни без изменений, вы не можете ударить союзника");
            }
            }

        public override string ToString()
        {
            return $"Имя персонажа: {Name}\n Раса первонажа: {Rasa}\n Количество здоровья: {Hp}\n ";
        }
    }
}