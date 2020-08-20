using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task11
{
    public class EqString {
        public static void main() {
            Console.Out.WriteLine("Введите первую строку: ");
            String st1 = Console.ReadLine();
            Console.Out.WriteLine("Введите вторую строку: ");
            String st2 = Console.ReadLine();
            if (st1.Length == st2.Length)
                Console.Out.WriteLine("Длины ваших строк равны.");
            else if (st1.Length > st2.Length)
                    Console.Out.WriteLine(st1);
                else Console.Out.WriteLine(st2);
        }
    }
}