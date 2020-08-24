

using System;
/**
* @author Sayapin Sergey
*
*/
public class Task3_1 {
    public static void main() {
       /*
       indexMin - индекс максимального отрицательного элемента
       indexMax - индекс минимального положительного элемента
        */
        int indexMin=0;
        int indexMax=0;
        Random random = new Random();
        //Пороги максимума и минимума чисел массива
        int min=11;
        int max=-11;
        int [] mass = new int[20];
        for (int i=0;i<20;i++) {
            mass[i] = (int) (random.Next(-10,10));
            if(mass[i]>0 && mass[i]<min){
                min=mass[i];
                indexMin=i;
            }
            if(mass[i]<0 && mass[i]>max){
                max=mass[i];
                indexMax=i;
            }
              Console.Out.Write(mass[i]+" ");
        }
        mass[indexMax]=min;
        mass[indexMin]=max;
          Console.Out.WriteLine();
        foreach (int element in mass
             ) {
              Console.Out.Write(element+" ");
        }
    }
}
