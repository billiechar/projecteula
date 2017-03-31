using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler {
    class Problem22 {
        public static string Name() {
            return "Names scores";
        }

        public static string Description() {
            string val = "Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.";
            val += "\n";
            val += "\n";
            val += "For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.";
            val += "\n";
            val += "\n";
            val += "What is the total of all the name scores in the file?";
            return val;
        }

        private static Dictionary<int, string> letterScores;

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string nameFile = System.IO.File.ReadAllText(@"C:\names.txt");
            nameFile = nameFile.Replace("\"", "");
            string[] names = nameFile.Split(',');
            int i = 0;
            double sum = 0;

            scoreLetters();

            foreach (string name in names.OrderBy(n => n)) {
                i++;
                sum += scoreName(name, i);
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(sum.ToString(), sw);
        }

        private static void scoreLetters() {
            int i = 1;
            letterScores = new Dictionary<int, string>();

            for (char c = 'A'; c <= 'Z'; c++) {
                letterScores.Add(i, c.ToString());
                i++;
            } 
        }

        private static double scoreName(string name, int position) {
            double nameScore = 0;
            foreach (char c in name) {
                nameScore += letterScores.SingleOrDefault(s => s.Value == c.ToString()).Key;
            }
            return (nameScore * position);
        }
    }
}
