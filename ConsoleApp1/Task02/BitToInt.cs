using System;

namespace ConsoleApp1.Task02
{
    public class BinToInt
    {
        public static void main()
        {
            //Console in= new Console(Console.in);
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
            //Перевод из 10-чной системы в 2-чную
            /*int A = in.nextInt();
            String B=" ";
            while (A!=0)
            {
                B=(A%2)+B;
                A=A/2;
            }
            System.out.println(B);*/
        }
    }
}
