using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task03
{
    public class Table {
        public static void main() {
            Console.Out.WriteLine("Введите целое число и нажмите 'ВВОД':");
            int X = int.Parse(Console.ReadLine());
            Console.Out.WriteLine("Таблица умножения числа " + X + ":");
            Console.Out.WriteLine(X + "x1=" + X);
            Console.Out.WriteLine(X + "x2=" + X * 2);
            Console.Out.WriteLine(X + "x3=" + X * 3);
            Console.Out.WriteLine(X + "x4=" + X * 4);
            Console.Out.WriteLine(X + "x5=" + X * 5);
            Console.Out.WriteLine(X + "x6=" + X * 6);
            Console.Out.WriteLine(X + "x7=" + X * 7);
            Console.Out.WriteLine(X + "x8=" + X * 8);
            Console.Out.WriteLine(X + "x9=" + X * 9);
            Console.Out.WriteLine(X + "x10=" + X * 10);
        }
    }
}