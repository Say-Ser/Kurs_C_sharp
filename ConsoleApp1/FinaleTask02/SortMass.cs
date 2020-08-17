using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FinaleTask02
{
    public class SortMass {
        public static void main() {
            int size;
            Random random = new Random();
            Console.Out.Write("Введите размерность массива: ");
            size = int.Parse(Console.In.ReadLine());
            int[] mass = new int[size];
            Console.Out.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < size; i++)
            {
                mass[i] = int.Parse(Console.In.ReadLine());
            }
            Console.Out.WriteLine("Ваш массив:");
            for (int i = 0; i < size; i++) {
                Console.Out.Write(mass[i] + " ");
            }
            // Сортировка выбором
            for (int min = 0; min < size - 1; min++) {
                int least = min;
                for (int j = min + 1; j < size; j++) {
                    if (mass[j] < mass[least])
                        least = j;
                }
                int tmp = mass[min];
                mass[min] = mass[least];
                mass[least] = tmp;
            }
            //----------------------
            Console.Out.WriteLine("Ваш массив отсортирован по возрастанию:");
            for (int i = 0; i < size; i++) {
                Console.Out.Write(mass[i] + " ");
            }

        }
    }
}