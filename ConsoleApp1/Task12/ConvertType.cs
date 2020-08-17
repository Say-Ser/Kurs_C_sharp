using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task12
{
    public class ConvertType {
        public static void main() {
            Console.Out.WriteLine("Введите число: ");
            string S = Console.ReadLine();
            int X = int.Parse(S);
            double Y = (double)X;
            Console.Out.WriteLine("Ваше число: ");
            Console.Out.WriteLine(S);
            Console.Out.WriteLine(X);
            Console.Out.WriteLine(Y);
        }
    }
}