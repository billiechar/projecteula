using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace ProjectEuler {
    class Problem25 {
        public static string Name() {
            return "1000-digit Fibonacci number";
        }

        public static string Description() {
            string val = "The Fibonacci sequence is defined by the recurrence relation:";
            val += "\n\n";
            val += "Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.";
            val += "\n\n";
            val += "Hence the first 12 terms will be:";
            val += "\n\n";
            val += "F1 = 1";
            val += "\nF2 = 1";
            val += "\nF3 = 2";
            val += "\nF4 = 3";
            val += "\nF5 = 5";
            val += "\nF6 = 8";
            val += "\nF7 = 13";
            val += "\nF8 = 21";
            val += "\nF9 = 34";
            val += "\nF10 = 55";
            val += "\nF11 = 89";
            val += "\nF12 = 144";
            val += "\n\n";
            val += "The 12th term, F12, is the first term to contain three digits.";
            val += "\n\n";
            val += "What is the first term in the Fibonacci sequence to contain 1000 digits?";
            return val;
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            BigInteger num1 = 1, num2 = 1, fibonacci = 0;
            int count = 2;

            do {
                fibonacci = num1 + num2;
                count++;
                num1 = num2;
                num2 = fibonacci;
            } while (fibonacci.ToString().Count() < 1000);

            sw.Stop();
            return globalMethods.DisplayAnswer(count.ToString(), sw);
        }
    }
}
