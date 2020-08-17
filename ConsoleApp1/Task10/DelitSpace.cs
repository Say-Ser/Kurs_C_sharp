using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task10
{
    public class DelitSpace {
        public static void main() {
            Console.Out.WriteLine("Введите строку с пробелами: ");
            string row = Console.ReadLine();
            string[] LostSpace = row.Split(" ");
            Console.Out.WriteLine("Ваша строка без пробелов: ");
            foreach (string s in LostSpace) {
                Console.Out.Write(s); 
            }
        }
    }
}