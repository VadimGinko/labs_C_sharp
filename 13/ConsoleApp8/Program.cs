using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            GVADiskInfo.FreePlaceOnDisk();
            GVADiskInfo.DiskFormat();
            GVADiskInfo.FullDiskInfo();

            GVAFileInfo file = new GVAFileInfo("D:\\Новая папка\\tes.txt");
            file.FileFullPlace();
            file.FileInfo();
            file.CreationTimeInfo();

            GVADirInfo Dir = new GVADirInfo("D:\\Новая папка");
            Dir.InfoPodDirs();
            Dir.FilesKolich();
            Dir.CreationTime();
            Dir.Parent();


            GVAFileManager.WriteListOfFilesAndDirectories("D:\\");

            string sourceFolder = "D://test/"; // исходная папка
            string zipFile = "D://test.zip"; // сжатый файл
            string targetFolder = "D://newtest"; // папка, куда распаковывается файл

            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
            ZipFile.ExtractToDirectory(zipFile, targetFolder);
            Console.WriteLine($"Файл {zipFile} распакован в папку {targetFolder}");
            Console.ReadKey();
        }
    }
}
