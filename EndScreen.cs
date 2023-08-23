using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Snake
{
    class EndScreen
    {
        public void Inscription(int b)
        {
            Console.SetWindowSize(51, 26);
            Console.SetBufferSize(51, 26);
            Console.Clear();
            string[] ss = new string[7];
            ss[0] = "ssssss s     s  ssss  ";
            ss[1] = "s      ss    s  s   s ";
            ss[2] = "s      s s   s  s    s";
            ss[3] = "ssss   s  s  s  s    s";
            ss[4] = "s      s   s s  s    s";
            ss[5] = "s      s    ss  s   s ";
            ss[6] = "ssssss s     s  ssss  \n";

            for (int i = 0; i < ss.Length; i++)
                for (int j = 0; j < ss[i].Length; j++)
                {
                    Console.SetCursorPosition(j + 14, i + 1);
                    Console.Write(ss[i][j]);
                }
            
            Console.WriteLine("\nSisestage oma nimi:");
            string name = "";
            name = Console.ReadLine();
            if (name == "") {name = "NoName";}
            Console.SetCursorPosition(17, 12);
            Console.Write("Sinu konto: {0}", b + "\n");

            StreamWriter sw = new StreamWriter("Scores.txt", true);
            sw.Write($"\n{name}:{b}");
            sw.Close();

            List<string> names = new List<string>();
            List<string> scores = new List<string>();

            Console.WriteLine("\nTop 10 parimat mängijat:");
            using (StreamReader sr = new StreamReader("Scores.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(':');
                    if (words.Length == 2)
                    {
                        names.Add(words[0]);
                        scores.Add(words[1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid line format: " + line);
                    }
                }
            }

            List<Tuple<string, string>> nameScorePairs = new List<Tuple<string, string>>();
            for (int i = 0; i < names.Count; i++)
            {
                nameScorePairs.Add(Tuple.Create(names[i], scores[i]));
            }

            nameScorePairs.Sort((pair1, pair2) => Convert.ToInt32(pair2.Item2).CompareTo(Convert.ToInt32(pair1.Item2)));

            int count = Math.Min(10, nameScorePairs.Count);
            for (int i = 0; i < count; i++)
            {
                var pair = nameScorePairs[i];
                Console.WriteLine($"{pair.Item1}: {pair.Item2}");
            }
            Console.ReadLine();
        }
    }
}
