using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler {
    class Problem7 {
        public static string Name() {
            return "10001st Prime";
        }

        public static string Description() {
            return "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\n\nWhat is the 10 001st prime number?";
        }

        public string Answer() {
            int i = 3;
            List<int> primes = new List<int>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            primes.Add(2);

            do {
                if (globalMethods.IsPrime(i) == true) {
                    primes.Add(i);
                }
                i += 2;
            } while (primes.Count <= 10000);

            sw.Stop();
            return globalMethods.DisplayAnswer(primes[10000].ToString(), sw);
        }
    }
}
