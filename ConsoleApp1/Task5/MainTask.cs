using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
/**
* @author Sayapin S.V.
*/
public class MainTask {
    public static void main() {
        try {
            string [] lines= File.ReadAllLines("C:/Users/user/IdeaProjects/JavaTask2_0/src/main/java/Task6/input.txt");
            ArrayList words = new ArrayList();
            foreach (string line in lines) {
                words.AddRange((line.Split("\\s")));
            }
            Collection. sort(words);
            Console.Out.WriteLine("Сортировка в афавитном порядке:");
            foreach (string word in words) {
                Console.Out.WriteLine("\t" + word);
            }
            Dictionary <String, int>  countWords =new HashMap<>();
            foreach (string word in words) {
                int count s=word.Length;
                if (count == null) {
                    count = 0;
                }
                countWords.Add(word, count +1);
            }
            Console.Out.Write("\nКоличество повторений: \n\t");
            foreach(Map.Entry<String, Integer> entry in countWords.entrySet())
                Console.Out.Write(entry.getKey() + " - " + entry.getValue() + " ");

            Collections.sort(words, new Comparator<String>() {
                public new int compare(String key1, String key2) {
                    return countWords.get(key2).compareTo(countWords.get(key1));
                }
            });
            Console.Out.Write("\n\nСлово с максималным количеством повторений: \n\t");
            Console.Out.WriteLine( words.get(0) + " = " + countWords.get(words.get(0)) + "\n");
        } catch (IOException ex) {
            Console.Out.WriteLine(ex.toString());
        }
    }
}