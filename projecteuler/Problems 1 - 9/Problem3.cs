using System.Diagnostics;

namespace ProjectEuler {
    class Problem3 {
        public static string Name() {
            return "Largest Prime Factor";
        }

        public static string Description() {
            return "The prime factors of 13195 are 5, 7, 13 and 29./n/nWhat is the largest prime factor of the number 600851475143 ?";
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double toFactor = 600851475143, result;
            int i = 1;

            do {
                i+=2;

                if (globalMethods.IsPrime(i) == true) {
                    result = toFactor / i;
                     if (result % 1 == 0) {
                        toFactor = result;
                    }
                }
            } while (globalMethods.IsPrime((int)toFactor) == false);

            sw.Stop();
            return globalMethods.DisplayAnswer(toFactor.ToString(), sw);
        }
    }
}
