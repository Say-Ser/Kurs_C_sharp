


using System;
/** Класс Калькулятор
* Класс включает в себя решения задач с 1 по 3 по курсу C#
* @author Sayapin S. V.
* */
public class Calc {

    /*Методы
    * Sum - функция сложения двух чисел
    * Min - функция сложения двух чисел
    * Del - функция сложения двух чисел
    * Umn - функция сложения двух чисел
    * Calculator - метод реализующий одну из операций (Сложение, Вычитание, Умножение и Деление), над двумя числами с плавающей точкой
    * FindMaxWordOfMassiv - метод реализующий поиск слова максимальной длины в массиве слов, заданной пользователем размерностью
     * */
    public static float Sum(float x,float y){
        return x + y;
    }
    public static float Min(float x,float y){
        return x - y;
    }
    public static float Del(float x,float y){
        return x / y;
    }
    public static float Umn(float x,float y){
        return x * y;
    }
    public static float Calculator(){
        Console.Out.WriteLine("Примечание: если число имеет дробную часть, просьба отделять ее запятой. ");
        Console.Out.WriteLine("Введите первое число: ");
        //first - первое число
        float first= float.Parse(Console.In.ReadLine());
        Console.Out.WriteLine("Введите второе число: ");
        //second - второе число
        float second= float.Parse(Console.In.ReadLine());
        Console.Out.WriteLine("Введите операцию: ");
        Console.Out.WriteLine("1 - сумма");
        Console.Out.WriteLine("2 - разность");
        Console.Out.WriteLine("3 - деление");
        Console.Out.WriteLine("4 - умножение");
        // operation - выбор операции над числами
        int operation = int.Parse(Console.In.ReadLine());
        float result;
        switch (operation){
            case 1:
                result=Sum(first,second);break;
            case 2:
                result=Min(first,second);break;
            case 3:
                result=Del(first,second);break;
            case 4:
                result=Umn(first,second);break;
            default:
                  Console.Out.WriteLine("Некорректная операция!");return 0;
        }
        return result;
    }
    private static string FindMaxWordOfMassiv() {
        int max=0;
        string maxWord = null;
          Console.Out.WriteLine("Введите размерность массива: ");
        int size = int.Parse(Console.In.ReadLine());
        Console.Out.WriteLine(size);
        string [] words = new string[size];
          Console.Out.WriteLine("Введите элементы массива: ");
        for (int i=0; i< words.Length;i++)
        {
            words[i] =  Console.In.ReadLine();
        }
          Console.Out.WriteLine("Ваш массив: ");

        foreach (string word in words)
        {
            if (word.Length>max)
            {
                max=word.Length;
                maxWord=word;
            }
        }

        foreach (string word in words)
        {
             Console.Out.Write(word+" ");
        }
          Console.Out.WriteLine(" ");

        return maxWord;
    }


    public static void main() {
          Console.Out.WriteLine("Введите номер программы, которую хотите запустить: ");
          Console.Out.WriteLine("1 - Калькулятор");
          Console.Out.WriteLine("2 - Поиск максимального слова в массиве");
        int number = int.Parse(Console.In.ReadLine());
        switch (number){
            case 1:
                string result = string.Format("{0:f4}",Calculator());
                Console.Out.Write("Результат выполнения программы Калькулятор: "+result);
                break;
            case 2:
                  Console.Out.WriteLine("Максимальное слово в массиве: "+FindMaxWordOfMassiv());
                break;
            default:
                Console.Out.WriteLine("Введен несуществующий номер, До свидания!");
                break;
        }


    }
    
}
