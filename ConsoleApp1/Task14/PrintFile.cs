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
            string path = @"C:\Users\W-book\source\repos\Say-Ser\Kurs_C_sharp\ConsoleApp1\Task14\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            /* if (!dirInfo.Exists)
                 dirInfo.Create();
             try {
                 try (FileStream filestream= new FileStream("C:\\Users\\user\\Documents\\GitHub\\HomeWork_Java_1_0\\src\\main\\Task16\\" + name,FileAccess.Read)) {
                     try {
                         while ((s = BR.In.ReadLine(); != null) {
                             System.out.println(s);
                         }
                     } finally {
                         BR.close();
                     }
                 }
                 } catch (IOException exc) {
                     Console.Out.WriteLine("Ошибка ввода-вывода: " + exc);
                 }
             }*/
            using (FileStream fstream = File.OpenRead($"{path}{name}"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
        }
    }
}