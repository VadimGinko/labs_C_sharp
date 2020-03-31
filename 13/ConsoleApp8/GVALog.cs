using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp8
{
    static class GVALog
    {
        static private readonly string _path = @"..\..\GVAlogfile.txt";


        static public void WriteLog(string text)
        {
            StreamWriter sw = new StreamWriter(_path, true);
            sw.WriteLine(DateTime.Now + " : " + text);
            sw.Close();
        }

        static public string FindLogByDate(string date)
        {
            string str = " ";

            foreach (string s in File.ReadLines(_path))
            {
                if (s.Contains(date))
                {
                    str += s + "\n";
                }
            }

            return str;
        }



        static public void LogForTheLastHours()
        {
            Console.WriteLine("lll");
            string date = DateTime.Now.ToString("dd.MM.yyy") + " " + DateTime.Now.Hour;
            Console.WriteLine("\n" + date);

            string LFTLH = FindLogByDate(date);

            StreamWriter sw = new StreamWriter(_path);
            sw.WriteLine(LFTLH);
            sw.Close();

        }
    }
}
