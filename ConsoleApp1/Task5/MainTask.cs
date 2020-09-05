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
      
        string exeDir = AppDomain.CurrentDomain.BaseDirectory;
        string relPath = @"..\..\..\Task5\input.txt"; // Относительный путь к файлу
        string resPath = Path.Combine(exeDir, relPath); // Объединяет две строки в путь.
        resPath = Path.GetFullPath(resPath); // Возвращает для указанной строки пути абсолютный путь.
        string lines = File.ReadAllText(resPath);
        string[] words = lines.Split(' ');
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

       Console.Out.WriteLine("Количество повторений: ");
       foreach (string word in countWords.Keys.OrderBy(x=>x))
        {
            Console.WriteLine(word+" - "+ countWords[word]);
        }

        int Max = 0;
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
