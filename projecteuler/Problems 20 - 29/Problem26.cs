using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler {
    class Problem26 {
        public static string Name() {
            return "Reciprocal cycles";
        }

        public static string Description() {
            string val = "A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:";
            val += "\n\n";
            val += "1/2	= 0.5";
            val += "\n1/3 =	0.(3)";
            val += "\n1/4 =	0.25";
            val += "\n1/5 = 0.2";
            val += "\n1/6 = 0.1(6)";
            val += "\n1/7 = 0.(142857)";
            val += "\n1/8 = 0.125";
            val += "\n1/9 = 0.(1)";
            val += "\n1/10 = 0.1";
            val += "\n\n";
            val += "Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.";
            val += "\n\n";
            val += "Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.";
            return val;
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int sequenceLength = 0, result = 0;

            for (int i = 1000; i > 1; i--) {
                if (sequenceLength >= i) {
                    break;
                }

                int[] foundRemainders = new int[i];
                int value = 1;
                int position = 0;

                while (foundRemainders[value] == 0 && value != 0) {
                    foundRemainders[value] = position;
                    value *= 10;
                    value %= i;
                    position++;
                }

                if (position - foundRemainders[value] > sequenceLength) {
                    sequenceLength = position - foundRemainders[value];
                    result = i;
                }
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(result.ToString(), sw);
        }
    }
}
