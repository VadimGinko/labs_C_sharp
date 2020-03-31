using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            ////////////Game/////////////////////
            Set<Person> Game = new Set<Person>();
            Person o = new Person();
            Dire D_player1 = new Dire(100, "Pudge");
            Radiant R_player2 = new Radiant(100, "Invoker");
            Dire D_player3 = new Dire(100, "Huscar");
            Radiant R_player4 = new Radiant(100, "Sniper");
            Game.Add(D_player1);
            Game.Add(D_player3);
            Game.Add(R_player2);
            Game.Add(R_player4);
            Event q = new Event();
            q.Register_Heal(o.Add_Hp);
            q.Register_Heal(o.Add_Hp_INFO);
            q.Register_Kick(o.Remove_Hp);
            q.Register_Kick(o.Remove_Hp_INFO);
            q.Go_Kick(D_player1, D_player3, 10, Game);
            Game.PrintAll();
            q.Go_Kick(D_player1, R_player2, 20, Game);
            Game.PrintAll();
            q.Go_Kick(R_player4, D_player3, 100, Game);
            Game.PrintAll();
            q.Go_Kick(R_player2, R_player4, 40, Game);
            Game.PrintAll();
            q.Go_Heal(D_player1, D_player3, 10, Game);
            Game.PrintAll();
            q.Go_Heal(D_player1, R_player2, 20, Game);
            Game.PrintAll();
            q.Go_Heal(R_player4, D_player3, 30, Game);
            Game.PrintAll();
            q.Go_Heal(R_player2, R_player4, 40, Game);
            Game.PrintAll();
            /////////////////////////////////////
            string Data = "Вадим Гинько";
            Action<string> action;
            action = (str) => Console.WriteLine(str.ToUpper());
            action += (str) => Console.WriteLine(str.ToLower());
            action += (str) => Console.WriteLine(str.Replace("о", ""));
            action += (str) => Console.WriteLine(str.Substring(0, str.Length - 2));
            action.Invoke(Data);
            Console.Read();
        }
    }
}
