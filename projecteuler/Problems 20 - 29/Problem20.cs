using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler {
    class Problem20 {
        public static string Name() {
            return "Factorial digit sum";
        }

        public static string Description() {
            string val = "n! means n × (n − 1) × ... × 3 × 2 × 1";
            val += "\n";
            val += "\n";
            val += "For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,\n";
            val += "and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.";
            val += "\n";
            val += "\n";
            val += "Find the sum of the digits in the number 100!";
            return val;
        }

        public string Answer() {
            int start = 100, sum = 0;
            BigInteger factorial = start;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            for (int i = start - 1; i > 0; i--) {
                factorial *= i;
            }

            foreach (char c in factorial.ToString().ToCharArray()) {
                sum += globalMethods.ReadInt32(c.ToString());
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(sum.ToString(), sw);
        }
    }
}
