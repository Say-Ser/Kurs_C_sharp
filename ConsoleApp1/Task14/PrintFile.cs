using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;


namespace ConsoleApp1.Task14
{
    public class PrintFile {
        public static void main() {
            Console.Out.WriteLine("Введите имя файла: (test.txt)");
            string name =Console.In.ReadLine();
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            string relPath = @"..\..\..\Task14\"; // Относительный путь к файлу
            string resPath = Path.Combine(exeDir, relPath); // Объединяет две строки в путь.
            resPath = Path.GetFullPath(resPath); // Возвращает для указанной строки пути абсолютный путь.
            using (FileStream fstream = File.OpenRead($"{resPath}{name}"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла:\n {textFromFile}");
            }
        }
    }
}