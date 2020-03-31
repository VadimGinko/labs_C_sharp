using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8
{
    class GVAFileInfo
    {
        private FileInfo _file;
        public GVAFileInfo(string Filename)
        {
            _file = new FileInfo(Filename);
        }

        public void FileFullPlace()
        {
            Console.WriteLine();
            Console.WriteLine($"Полный путь к файлу {_file.Name} :  {_file.DirectoryName}");

            GVALog.WriteLog(" Пользователь воспользовался методом FileFullPlace() ");
        }

        public void FileInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"\tИмя файла: {_file.Name}");
            Console.WriteLine($"Размер файла: {_file.Length} bytes");
            Console.WriteLine($"Расширение файла : {_file.Extension}");
            Console.WriteLine($"Размер файла: {_file.Length} bytes");

            GVALog.WriteLog(" Пользователь воспользовался методом FileInfo() ");
        }

        public void CreationTimeInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Дата и время создания файла: {_file.Name} : {_file.CreationTime}");

            GVALog.WriteLog(" Пользователь воспользовался методом CreationTimeInfo() ");
        }
    }
}
