using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8
{
    static class GVADiskInfo
    {
        static public void FreePlaceOnDisk()// информация о диске
        {
            Console.WriteLine();
            var Drivers = DriveInfo.GetDrives();
            foreach (var driver in Drivers)
            {
                if (!driver.IsReady) continue;
                Console.WriteLine($"Свободное место на диске {driver.Name} : {driver.AvailableFreeSpace} bytes");
            }

            GVALog.WriteLog(" Пользователь воспользовался методом FreePlaceOnDisk() ");
        }

        static public void DiskFormat()
        {
            Console.WriteLine();
            var Drivers = DriveInfo.GetDrives();
            foreach (var driver in Drivers)
            {
                if (!driver.IsReady) continue;
                Console.WriteLine($"Формат диска: {driver.Name} : {driver.DriveFormat}");
            }

            GVALog.WriteLog(" Пользователь воспользовался методом DiskFormat() ");
        }

        static public void FullDiskInfo()
        {
            Console.WriteLine();
            var Drivers = DriveInfo.GetDrives();
            foreach (var driver in Drivers)
            {
                if (!driver.IsReady) continue;
                Console.WriteLine($"\tИмя диска: {driver.Name} ");
                Console.WriteLine($"Объём диска: {driver.TotalSize} ");
                Console.WriteLine($"Свободное место на диске: {driver.TotalFreeSpace}");
                Console.WriteLine($"Метка тома: {driver.VolumeLabel} ");
            }

            GVALog.WriteLog(" Пользователь воспользовался методом FullDiskInfo() ");
        }

    }
}
