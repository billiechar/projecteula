
using System.Diagnostics;
namespace ProjectEuler {
    class Problem5 {
        public static string Name() {
            return "Smallest Multiple";
        }

        public static string Description() {
            return "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.\n\nWhat is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
        }

        public string Answer() {
            int i = 2519;
            int n = 20;
            bool divisable = true;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            do {
                i++;
                divisable = true;

                for (n = 20; n > 0; n--) {
                    if (i % n != 0) {
                        divisable = false;
                        n = 0;
                    }
                }
            } while (divisable == false);

            sw.Stop();
            return globalMethods.DisplayAnswer(i.ToString(), sw);
        }
    }
}
