using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler {
    class Problem21 {
        public static string Name() {
            return "Amicable numbers";
        }

        public static string Description() {
            string val = "Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).";
            val += "If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.";
            val += "\n";
            val += "\n";
            val += "For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.";
            val += "\n";
            val += "\n";
            val += "Evaluate the sum of all the amicable numbers under 10000.";
            return val;
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<int> amicableNumbers = new List<int>();
            for (int i = 1; i <= 10000; i++) {
                int sum = divisorSum(i);
                int sum2 = divisorSum(sum);
                
                if (i == sum2 && sum2 <= 10000 && i != sum) {
                    amicableNumbers.Add(i);
                }
            }

            int amicableSum = 0;
            foreach (int num in amicableNumbers) {
                amicableSum += num;
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(amicableSum.ToString(), sw);
        }

        private static int divisorSum(int n) {
            if (n < 1) { return 0; }
            List<int> nDivisors = globalMethods.divisors(n);
            int sum = 0;

            foreach (int i in nDivisors) {
                if (i != n) { sum += i; }
            }

            return sum;
        }
    }
}
