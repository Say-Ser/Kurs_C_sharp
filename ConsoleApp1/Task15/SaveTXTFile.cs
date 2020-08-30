using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace ConsoleApp1.Task15
{

    public class SaveTXTFile {
        public static void main() {
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            string relPath = @"..\..\..\Task15\"; // Относительный путь к файлу
            string resPath = Path.Combine(exeDir, relPath); // Объединяет две строки в путь.
            resPath = Path.GetFullPath(resPath); // Возвращает для указанной строки пути абсолютный путь.
           // string resPath = @"C:\Users\W-book\source\repos\Say-Ser\Kurs_C_sharp\ConsoleApp1\Task15\";
            DirectoryInfo dirInfo = new DirectoryInfo(resPath);
            if (!dirInfo.Exists)
                 dirInfo.Create();
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            // запись в файл
            using (FileStream fstream = new FileStream($"{resPath}note.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }
        }
    }
}