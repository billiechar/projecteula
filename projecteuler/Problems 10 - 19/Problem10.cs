
using System.Diagnostics;
namespace ProjectEuler {
    class Problem10 {
        public static string Name() {
            return "Summation of primes";
        }

        public static string Description() {
            return "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.\n\nFind the sum of all the primes below two million.";
        }

        public string Answer() {
            long total = 2;
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 3; i < 2000000; i += 2) {
                if (globalMethods.IsPrime(i) == true) {
                    total += i;
                }
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(total.ToString(), sw);
        }
    }
}
