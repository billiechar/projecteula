using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler {
    class Problem16 {
        public static string Name() {
            return "Power digit sum";
        }

        public static string Description() {
            return "2 to the power 15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.\n\nWhat is the sum of the digits of the number 2 to the power 1000?";
        }

        public string Answer() {
            int power = 1000;
            BigInteger result = 1;
            int sum = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < power; i++) {
                result *= 2;
            }

            char[] resultDigits = result.ToString().ToCharArray();

            foreach (var c in resultDigits) {
                sum += globalMethods.ReadInt32(c.ToString());
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(sum.ToString(), sw);
        }
    }
}
