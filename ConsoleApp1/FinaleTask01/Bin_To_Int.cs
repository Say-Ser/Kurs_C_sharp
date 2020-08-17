using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FinaleTask01
{
    public class Bin_To_Int
    {
        public static void main()
        {
            Console.Out.WriteLine("Введите число в бинарном виде и нажмите 'ВВОД':");
            String A = Console.In.ReadLine();
            char[] B = A.ToCharArray();
            Console.Out.WriteLine(B);
            int C = 0;
            for (int i = B.Length - 1; i >= 0; i--)
            {
                if (B[i] == '1')
                    C = (int)(C + Math.Pow(2, i));
            }
            Console.Out.WriteLine("Ваше число в 10-чной записи:");
            Console.Out.WriteLine(C);

        }
    }
}