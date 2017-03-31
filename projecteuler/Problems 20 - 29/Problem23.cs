using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler {
    class Problem23 {
        public static string Name() {
            return "Non-abundant sums";
        }

        public static string Description() {
            string val = "A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.";
            val += "\n";
            val += "\n";
            val += "A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.";
            val += "\n";
            val += "\n";
            val += "As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.";
            val += "\n";
            val += "\n";
            val += "Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.";
            return val;
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<int> abundantNumbers = new List<int>();

            for (int i = 12; i <= 28123; i++ ) {
                if (abundantNumber(i) != 0) { abundantNumbers.Add(i); }
            }

            bool[] sumOf2Abundants = new bool[28124];
            for (int i = 0; i < 14062; i++) {
                for(int n = i; n < abundantNumbers.Count; n++) {
                    if(abundantNumbers[i] + abundantNumbers[n] <= 28123) {
                        sumOf2Abundants[abundantNumbers[i] + abundantNumbers[n]] = true;
                    }
                }
            }

            int sum = 0;
            for (int i = 1; i <= 28123; i++) {
                if (!sumOf2Abundants[i]) { sum += i; }
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(sum.ToString(), sw);
        }

        public int abundantNumber(int n) {
            List<int> nDivisors = globalMethods.divisors(n);
            int sum = 0;

            foreach (int divisor in nDivisors) {
                if (divisor != n) { sum += divisor; }
                if (sum > n) { return n; }
            }
            return 0;
        }
    }
}
