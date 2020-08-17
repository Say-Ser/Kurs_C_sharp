using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task05
{
    public class Const {
        public static void main() {
            double number, X, Y, Z;
            X = 6.23;
            Y = 2.73;
            Z = 3.14;
            Console.Out.WriteLine("Введите число: ");
            number = double.Parse(Console.In.ReadLine());
            if (number == X || number == Y || number == Z) {
                Console.Out.WriteLine("Данное значение имеется в константах");
            }
            else Console.Out.WriteLine("Такой константы нет!");
        }
    }
}