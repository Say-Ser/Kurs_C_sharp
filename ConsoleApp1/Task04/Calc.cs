using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task04 {

    public class Calc {
        public static void main() {
            int x, y, z;
            float avg;
            Console.Out.WriteLine("Введите целые x, y, z : ");
            x = int.Parse(Console.In.ReadLine());
            y = int.Parse(Console.In.ReadLine());
            z = int.Parse(Console.In.ReadLine());
            avg = (float)((x + y + z) / 3.0);
            Console.Out.WriteLine("Среднее арифметическое x, y, z: " + avg);
            if ((int)avg / 2 > 3) {
                Console.Out.WriteLine("Программа выполнена корректно");
            }
        }
    }
}