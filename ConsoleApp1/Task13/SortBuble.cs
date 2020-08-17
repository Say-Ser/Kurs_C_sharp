using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task13
{
    public class SortBuble {
        public static void main() {
            int size;
            Random random = new Random();
            Console.Out.WriteLine("Введите размерность массива: ");
            size = int.Parse(Console.In.ReadLine());
            int[] mass = new int[size];
            for (int i = 0; i < size; i++)
            {
                mass[i] = random.Next(20);
            }
            Console.Out.WriteLine("Ваш массив:");
            for (int i = 0; i < size; i++) {
                Console.Out.Write(mass[i] + " ");
            }
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size - 1; j++) {
                    if (mass[j] > mass[j + 1]) {
                        int tmp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = tmp;
                    }
                }
            }
            Console.Out.WriteLine("Ваш массив отсортирован:");
            for (int i = 0; i < size; i++)
                Console.Out.Write(mass[i] + " ");
        }
    }
}