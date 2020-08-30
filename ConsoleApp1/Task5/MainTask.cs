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
            string lines= File.ReadAllText("C:/Users/W-book/source/repos/Say-Ser/Kurs_C_sharp/ConsoleApp1/Task5/input.txt");
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            string relPath = @"..\..\..\Task15\"; // Относительный путь к файлу
            string resPath = Path.Combine(exeDir, relPath); // Объединяет две строки в путь.
            resPath = Path.GetFullPath(resPath); // Возвращает для указанной строки пути абсолютный путь.
            string[] words = lines.Split(' ');
            var sortedwords = from word in words orderby word select word;
            Console.Out.WriteLine("Сортировка в афавитном порядке:");
            foreach (string word in sortedwords) {
                Console.Out.WriteLine("\t" + word);
            }
            
           // Dictionary <string, int>  countWords =new Dictionary<string,int>();
            
            words.GroupBy(x => x).OrderBy(g => g.Count()).Select(g => g.Key);
            
        /*  for(int i = 0; i < words.Length;) { 
              int j;
              for (j = i + 1; j < words.Length; j++)
              {
                  if (words[i] != words[j])
                  {
                      countWords.Add(words[i], j - i);
                      i = j;
                      break;
                  }
              }
              if (j == words.Length)
              {
                  countWords.Add(words[i], j - i);
                  break;
              }
          }
        */
        Console.Out.Write("\nКоличество повторений: \n\t");
            foreach(string entry in words)
                Console.Out.Write(entry);

          /*  Collections.sort(words, new Comparator<String>() {
                public new int compare(String key1, String key2) {
                    return countWords.get(key2).compareTo(countWords.get(key1));
                }
            });
            Console.Out.Write("\n\nСлово с максималным количеством повторений: \n\t");
            Console.Out.WriteLine( words.get(0) + " = " + countWords.get(words.get(0)) + "\n");
        } catch (IOException ex) {
            Console.Out.WriteLine(ex.toString());
        }*/
    }
}
