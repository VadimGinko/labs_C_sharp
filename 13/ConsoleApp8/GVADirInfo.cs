using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8
{
    class GVADirInfo
    {
        private string _dirname;

        public GVADirInfo(string Filename)
        {
            _dirname = Filename;
        }

        public void CreationTime()
        {
            Console.WriteLine();
            Console.WriteLine($"Дата создания директория: {Directory.GetCreationTime(_dirname)}");

            GVALog.WriteLog(" Пользователь воспользовался методом CreationTime() ");
        }

        public void FilesKolich()
        {
            Console.WriteLine();
            if (Directory.Exists(_dirname))
            {
                Console.WriteLine();
                string[] files = Directory.GetFiles(_dirname);
                Console.WriteLine("Количество Файлов:" + files.Length);
            }

            GVALog.WriteLog(" Пользователь воспользовался методом FilesKolich() ");
        }

        public void InfoPodDirs()
        {
            Console.WriteLine();
            if (Directory.Exists(_dirname))
            {
                string[] dirs = Directory.GetDirectories(_dirname);
                Console.WriteLine("Количество подкаталогов:" + dirs.Length);
            }

            GVALog.WriteLog(" Пользователь воспользовался методом InfoPodDirs() ");
        }

        public void Parent()
        {
            if (Directory.Exists(_dirname))
            {
                string Parent = Directory.GetParent(_dirname).FullName;
                Console.WriteLine("Родительский каталог: " + Parent);
            }

            GVALog.WriteLog(" Пользователь воспользовался методом Parent() ");
        }
    }
}
