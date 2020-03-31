using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8
{
        static class GVAFileManager
        {
            static public void WriteListOfFilesAndDirectories(string path)
            {
                Console.WriteLine($"Disk Name: {path}");
                Console.WriteLine("Directories: ");
                var directories = Directory.GetDirectories(path);
                foreach (var item in directories)
                    Console.WriteLine($"\t{item}");

                Console.WriteLine("Files: ");
                var files = Directory.GetFiles(path);
                foreach (var item in files)
                    Console.WriteLine($"\t{item}");


                GVALog.WriteLog(" Пользователь воспользовался методом WriteListOfFilesAndDirectories() ");

            }

            static public void CreateDirectory(string path)
            {
                if (Directory.Exists(path))
                    Console.WriteLine($"Directory {path} already exist!");
                else
                {
                    Directory.CreateDirectory(path);
                }

                
                GVALog.WriteLog(" Пользователь воспользовался методом CreateDirectory() ");
            }

            static public void CreateFile(string path)
            {
                if (File.Exists(path))
                    Console.WriteLine($"File {path} already exist!");
                else
                {
                    File.Create(path);
                }

                
                GVALog.WriteLog(" Пользователь воспользовался методом CreateFile() ");
            }

            static public void CopyFile(string originPath, string newPath)
            {
                if (File.Exists(newPath))
                    Console.WriteLine($"File {originPath} already exist!");
                else
                {
                    File.Copy(originPath, newPath);
                }
                
                GVALog.WriteLog(" Пользователь воспользовался методом CopyFile() ");
            }

            static public void DeleteFile(string path)
            {
                if (File.Exists(path))
                    File.Delete(path);
                else
                    Console.WriteLine($"File {path} not found!");

                
                GVALog.WriteLog(" Пользователь воспользовался методом DeleteFile() ");
            }

            static public void SaveStringInFile(string path, string Data)
            {
                if (!File.Exists(path))
                    return;
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(Data);
                }

                
                 GVALog.WriteLog(" Пользователь воспользовался методом SaveStringInFile() ");
            }

            static public string ReadAllInformationFromFile(string path)
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine($"File {path} not found");
                    return null;
                }
                GVALog.WriteLog(" Пользователь воспользовался методом ReadAllInformationFromFile() ");
                using (StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }

                
            }

            static public void CopyFilesFromTo(string originDir, string newDir, string extension)
            {
                if (!Directory.Exists(originDir))
                {
                    Console.WriteLine($"{originDir} not found");
                    return;
                }

                if (!Directory.Exists(originDir))
                {
                    CreateDirectory(newDir);
                }


                var OD = new DirectoryInfo(originDir);
                var ODfiles = OD.GetFiles();

                foreach (var item in ODfiles)
                {
                    string name = Path.Combine(newDir, item.Name);
                    if (item.Extension == extension)
                    {
                        if (!File.Exists(name))
                            item.CopyTo(name);
                    }

                }
                
                GVALog.WriteLog(" Пользователь воспользовался методом CopyFilesFromTo() ");
            }
        }
}
