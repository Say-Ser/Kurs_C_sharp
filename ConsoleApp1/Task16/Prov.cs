using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace ConsoleApp1.Task16
{
    public class Prov
    {
        public static void main()
        {
            Console.Out.WriteLine("Введите имя файла: (note.txt)");
            string name = Console.In.ReadLine();
            string path = @"C:\Users\W-book\source\repos\Say-Ser\Kurs_C_sharp\ConsoleApp1\Task16\";
            _ = new DirectoryInfo(path);
            int count = 1;
            using (FileStream fstreamout = File.OpenRead($"{path}{name}"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstreamout.Length];
                // считываем данные
                fstreamout.Read(array, 0, array.Length);
                foreach (byte ch in array)
                {
                    if (ch == 10)
                        count++;
                }
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла:\n {textFromFile}\n");
                Console.WriteLine(count);
            }
           
            Console.WriteLine("Введите текст для записи в файл:");
            using FileStream fstreamin = new FileStream($"{path}note.txt", FileMode.OpenOrCreate);
            while (count != 0) 
            {
                string text = Console.ReadLine();
                // запись в файл

                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text+'\n');
                // запись массива байтов в файл
                fstreamin.Write(array, 0, array.Length);

                count--;
            }
            Console.WriteLine("Текст записан в файл");
        }
        /* public static void main()
        {
            String s;
            int count = 0;
            Scanner in = new Scanner(System.in);
             System.out.println("Введите имя файла: (test.txt)");
             String name = in.nextLine();
             try {
                 try (BufferedReader BR = new BufferedReader(new FileReader("C:\\Users\\user\\Documents\\GitHub\\HomeWork_Java_1_0\\src\\main\\Task18\\" + name))) {
                     try {
                         while ((s = BR.readLine()) != null) {
                             System.out.println(s);
                             count++;
                         }
                     } finally {
                         BR.close();
                     }
                 }
             } catch (
                     IOException exc) {
                 System.out.println("Ошибка ввода-вывода: " + exc);
             }
             //Надо как то получить количество вводимых строк count будет их считать
             BufferedReader BR = new BufferedReader(new InputStreamReader(System.in));
             System.out.println("Измените необходимый текст: ");
             try(FileWriter fw= new FileWriter("C:\\Users\\user\\Documents\\GitHub\\HomeWork_Java_1_0\\src\\main\\Task18\\test.txt")) {
                 do{
                     s = BR.readLine();
                     if(count==0) break;
                     s=s+"\r\n";
                     fw.write(s);
                     count--;
                 } while (count!=0);
             }catch (IOException exc){
                 System.out.println("Ошибка ввода-вывода: "+ exc);
             }
            */
    }
 }