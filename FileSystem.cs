using System;
using System.IO;
using System.Linq;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Third();
        }

        static void First()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                Console.WriteLine($"{i+1}. Имя: {drives[i].Name}\n   " +
                    $"Доступное свободное место в байтах: {drives[i].AvailableFreeSpace}\n   " +
                    $"Общий размер диска в байтах: {drives[i].TotalSize}.");
            }
        }

        static void Second()
        {

        }

        static void Third()
        {
            string groupFolder = "/Users/232021/Desktop/Группа/";
            string[] directories = Directory.GetDirectories(groupFolder),
                     files = Directory.GetFiles(groupFolder);

            Console.WriteLine("Список подкаталогов:");
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine($"{i+1}. {Path.GetFileName(directories[i])}");
            }
            

            Console.WriteLine("Список файлов:");
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{i+1}. {Path.GetFileName(files[i])}");
            }

            Console.WriteLine("Список документов Excel: ");
            string[] excelFiles = files.Where(file => Path.GetExtension(file) == ".xlsx").ToArray<String>();
            for (int i = 0; i < excelFiles.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Path.GetFileName(excelFiles[i])}");
            }
        }

        static void Fourth()
        {
            string groupFolder = "/Users/232021/Desktop/Группа/Группа 323";

            Console.WriteLine("Удаление каталога \"Группа 323\", если он существует.");
            if (Directory.Exists(groupFolder))
                Directory.Delete(groupFolder);
        }

        static void Fifth()
        {
            string groupFolder = "/Users/232021/Desktop/Группа/";
            string fileName = "База данных 123 группа.xlsx";
            string sourceFilePath = groupFolder + fileName;
            string destFilePath = groupFolder + "Группа 123/" + fileName;


            Directory.Move(sourceFilePath, destFilePath);
        }
    }
}
