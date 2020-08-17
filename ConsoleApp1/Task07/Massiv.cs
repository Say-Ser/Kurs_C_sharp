using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task07
{
    public class Massiv {
        public static void main() {

            Console.Out.WriteLine("Введите размерность массива: ");
            int size = int.Parse(Console.In.ReadLine());
            int[] mass = new int [size];
            Console.Out.WriteLine("Введите элементы массива через новую строку: ");
            for (int i=0;i<size;i++) 
            {
                mass[i] = int.Parse(Console.In.ReadLine());
            }
            Console.Out.WriteLine("Ваш удвоенный массив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Out.WriteLine(mass[i] * 2 + " ");
            }
            
        }
    }
}