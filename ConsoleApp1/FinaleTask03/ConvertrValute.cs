using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FinaleTask03
{
    public class ConvertrValute
    {
        public static void main()
        {
            Console.Out.WriteLine("Введите текущий курс:");
            Console.Out.Write("Курс доллара = ");
            float Kurs = float.Parse(Console.In.ReadLine());
            Console.Out.WriteLine("Введите количество рублей:");
            float Rub = float.Parse(Console.In.ReadLine());
            float Dollar = Rub / Kurs;
            string result = String.Format("{0:f2}", Dollar);
            Console.Out.WriteLine("Итого: " + result + " долларов.");
        }
    }
}