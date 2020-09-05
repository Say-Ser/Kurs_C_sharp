using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;

/**
* @author Sayapin S.V.
*/
public class MainTask {
    public static void main() {
        // try {

        string exeDir = AppDomain.CurrentDomain.BaseDirectory;
        string relPath = @"..\..\..\Task5\input.txt"; // Относительный путь к файлу
        string resPath = Path.Combine(exeDir, relPath); // Объединяет две строки в путь.
        resPath = Path.GetFullPath(resPath); // Возвращает для указанной строки пути абсолютный путь.
        string lines = File.ReadAllText(resPath);
        string[] words = lines.Split(' ');
        //    string[,] resultwords;
        
        // Console.Out.WriteLine("Сортировка в афавитном порядке:");
        /*  foreach (string word in sortedwords) {
              Console.Out.WriteLine("\t" + word);
          }*/
        // int count=1;
        /* resultwords[0,0] = {{ words[0], "0"} };


             if(resultwords[i,i] == words[i])
         }*/

          


       Dictionary<string, int> countWords = new Dictionary<string, int>();


        foreach (string word in words.Distinct())
            countWords.Add(word, 0);

        foreach(string word in words)
        {
        foreach (string c in words.Distinct())
            {
                if (c == word)
                    countWords[c]++;
            }
        }
        /* for(int i = 0; i < words.Length;) { 
               int j;
               for (j = i + 1; j < words.Length; j++)
               {
                   if (words[i] != words[j])
                   {
                       countWords[words[i]]= j - i;
                       i = j;
                       break;
                   }
               }
               if (j == words.Length)
               {
                   countWords[words[i]]= j - i;
                   break;
               }
           }
         */
        // countWords.Add(words[0], 1);
        /*
        for (int j = 0; j < words.Length; j++)
            for (int i = 1; i < words.Length; i++)
            {
                if (words[j] == words[i])
                    countWords[words[j]]++;
            }
        */
        /* for (int i = 1; i < words.Length; i++)
         {
             if (words[i - 1] != words[i])
                 countWords.Add(words[i], 1);
             //countWords.Values++;
         }*/
        //var sortedwords = from word in countWords orderby word select word;
       // countWords.GroupBy(x => x).OrderBy(g => g.Count()).Select(g => g.Key);
       
       /*
        int[] count=new int[words.Length];
        count[0] = 1;
         for(int i = 0; i < words.Length; i++) 
            for(int j = 1; j < words.Length; j++)
            {
                if (words[i] == words[j])
                count[i]++;
            }
       */
        Console.Out.WriteLine("Количество повторений: ");
       foreach (string word in countWords.Keys.OrderBy(x=>x))
        {
            Console.WriteLine(word+" - "+ countWords[word]);
        }

        int Max = 0;
        //string MaxWord=" " ;
        int CountWord = -1;
        foreach (int i in countWords.Values)
        {
            if (i > Max)
            {
                Max = i;
                CountWord++;
            }
        }

          Console.Out.Write("\n\nСлово с максималным количеством повторений: \n");
         Console.Out.WriteLine( countWords.ElementAt(CountWord).Key + " - " +  Max + "\n");
      
    }
}
