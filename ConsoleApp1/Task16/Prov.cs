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

            string path = @"C:\Users\W-book\source\repos\Say-Ser\Kurs_C_sharp\ConsoleApp1\Task16\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
                dirInfo.Create();
            Console.WriteLine("Введите текст для записи в файл:");
            string text=" ";
            using FileStream fstream = new FileStream($"{path}note.txt", FileMode.OpenOrCreate);
            while (text != "stop") 
            {
                text = Console.ReadLine();
                // запись в файл
                
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text+'\n');
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                

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