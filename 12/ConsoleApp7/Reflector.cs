using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ConsoleApp7
{
    class Reflector
    {
        public static void ClassInfoInFile(string className)
        {
            Type myType = Type.GetType(className);
            using (StreamWriter sw = new StreamWriter(@"..\..\TypeInfo.txt", false, System.Text.Encoding.Default))
            {
                foreach (MemberInfo mi in myType.GetMembers())
                {
                    sw.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
                }
            }
        }

        public static void Out_Constructors(string className)
        {
            Type myType = Type.GetType(className, false, true);

            Console.WriteLine("Методы:");
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";
                Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");
                //получаем все параметры
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }

        public static void Out_Interfaces(string className)
        {
            Type myType = Type.GetType(className, false, true);
            Console.WriteLine("Реализованные интерфейсы:");
            foreach (Type i in myType.GetInterfaces())
            {
                Console.WriteLine(i.Name);
            }
        }

        public static void Metods_po_parametry(string className, Type Param)
        {
            Type Class = Type.GetType(className, false, true);
            Console.WriteLine($"Классы с параметром типа {Param}");
            foreach (MethodInfo methodInfo in Class.GetMethods())
            {
                foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
                {
                    if (parameterInfo.ParameterType == Param)
                    {
                        Console.Write($"{methodInfo.ReturnType.Name} {methodInfo.Name} (");
                        ParameterInfo[] parameters = methodInfo.GetParameters();
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                            if (i + 1 < parameters.Length) Console.Write(", ");
                        }
                        Console.WriteLine(")");
                    }
                }
            }
        }

        public static void CallMethod(string ClassName, string MethodName)
        {
            Assembly asm = Assembly.LoadFrom(ClassName);
            Type t = asm.GetType("ConsoleApp7.User");

            object obj = Activator.CreateInstance(t);

            MethodInfo method = t.GetMethod(MethodName);

            string[] parm;
            // Чтение параметров из файла
            using (FileStream fstream = File.OpenRead(@"..\..\note.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                char[] separators = { ' ' };
                parm = textFromFile.Split(separators);
                int k = Int32.Parse(parm[0]);
                int k2 = Int32.Parse(parm[1]);

                object result = method.Invoke(obj, new object[] { k, k2 });
            }
        }
    }
}
