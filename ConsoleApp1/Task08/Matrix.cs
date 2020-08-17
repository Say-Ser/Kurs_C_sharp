using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Task08
{
   
    public class Matrix {
        public static void main() {
            Console.Out.WriteLine("Введите размерность матрицы (строк, столбцов): ");
            int row = int.Parse(Console.In.ReadLine());
            int col = int.Parse(Console.In.ReadLine());
            int[,] matr = new int[row,col];
            Console.Out.WriteLine("Введите элементы матрицы через пробел: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matr[i,j] = int.Parse(Console.In.ReadLine());
                }

            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Out.Write(matr[i,j] + " ");
                }
                Console.Out.Write('\n');
            }


            for (int j = 0; j <= row; j++)
            {
                Console.Out.Write(matr[0,j] * 3 + " ");
            }
        }
    }
}