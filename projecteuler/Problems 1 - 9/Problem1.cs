
using System.Diagnostics;


namespace ProjectEuler {
    class Problem1 {
        public static string Name() {
            return "Multiples of 3 and 5";
        }

        public static string Description() {
            return "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.\n\nFind the sum of all the multiples of 3 or 5 below 1000.";
        }

        private static int target = 999;

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int total =0, i;

            for (i = 1; i <= target; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    total += i;
                }
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(total.ToString(), sw);
        }
    }
}
