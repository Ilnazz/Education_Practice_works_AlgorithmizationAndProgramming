using System;
using System.IO;
using System.Linq;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.");
            First();
            Console.WriteLine("\nЗадание 3.");
            Third();
            Console.WriteLine("\nЗадание 4.");
            Fourth();
            Console.WriteLine("\nЗадание 5.");
            Fifth();
            Console.WriteLine("\nЗадание 6.");
            Sixth();
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
            {
                Directory.Delete(groupFolder);
                Console.WriteLine("Каталог \"Группа 323\" удален.");
            }
            else
            {
                Console.WriteLine("Каталог \"Группа 323\" не существует.");
            }
        }

        static void Fifth()
        {
            string firstSourceFilePath = "/Users/232021/Desktop/Группа/База данных 123 группа.xlsx";
            string firstDestFilePath = "/Users/232021/Desktop/Группа/Группа 123/База данных 123 группа.xlsx";
            Console.WriteLine("Перемещение файла \"База данных 123 группы.xlsx\" в каталог \"Группа 123\", если он существует.");
            if (Directory.Exists(firstSourceFilePath))
            {
                Directory.Move(firstSourceFilePath, firstDestFilePath);
                Console.WriteLine("Файл перемещен.");
            }
            else
            {
                Console.WriteLine("Файл уже был перемещен.");
            }
                

            string secondSourceFilePath = "/Users/232021/Desktop/Группа/Сводный лист 223 группа.xlsx";
            string secondDestFilePath = "/Users/232021/Desktop/Группа/Группа 223/Сводный лист 223 группа.xlsx";
            Console.WriteLine("Перемещение файла \"Сводный лист 223 группа.xlsx\" в каталог \"Группа 223\", если он существует.");
            if (Directory.Exists(secondSourceFilePath))
            {
                Directory.Move(secondSourceFilePath, secondDestFilePath);
                Console.WriteLine("Файл перемещен.");
            }
            else
            {
                Console.WriteLine("Файл уже был перемещен.");
            }
        }

        static void Sixth()
        {
            string directoryPath = "/Users/232021/Desktop/Группа/Группа 223/";
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            DateTime creationTime = directory.CreationTime,
                     lastWriteTime = directory.LastWriteTime;
            string absolutePath = directory.FullName,
                   parentDirectory = directory.Parent.Name;

            Console.WriteLine($"Время создания каталога: {creationTime},\n" +
                              $"Время последнего изменения каталога: {lastWriteTime},\n" +
                              $"Полный путь к каталогу: {absolutePath},\n" +
                              $"Родительский каталог: {parentDirectory}.");

        }
    }
}
