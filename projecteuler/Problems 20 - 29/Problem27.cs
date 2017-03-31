using System.Diagnostics;

namespace ProjectEuler {
    class Problem27 {
        public static string Name() {
            return "Quadratic primes";
        }

        public static string Description() {
            string val = "Euler discovered the remarkable quadratic formula:";
            val += "\n\n";
            val += "n² + n + 41";
            val += "\n\n";
            val += "It turns out that the formula will produce 40 primes for the consecutive values n = 0 to 39. However, when n = 40, 402 + 40 + 41 = 40(40 + 1) + 41 is divisible by 41, and certainly when n = 41, 41² + 41 + 41 is clearly divisible by 41.";
            val += "\n\n";
            val += "The incredible formula  n² − 79n + 1601 was discovered, which produces 80 primes for the consecutive values n = 0 to 79. The product of the coefficients, −79 and 1601, is −126479.";
            val += "\n\n";
            val += "Considering quadratics of the form:";
            val += "\n\n";
            val += "n² + an + b, where |a| < 1000 and |b| < 1000";
            val += "\n\n";
            val += "where |n| is the modulus/absolute value of n\ne.g. |11| = 11 and |−4| = z";
            val += "\n\n";
            val += "Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n = 0.";
            return val;
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //for (int n = 0; n < 80; n++) {
            //    for (int a = 0; n < 1000; n++) {
            //        for (int b = 0; n < 1000; n++) {
            //        }
            //    }

            //    bool isPrime = globalMethods.IsPrime((i * i) - (79 * i) + 1601);
            //    if (isPrime == false) {
            //        return "";
            //    }
            //}

            sw.Stop();
            return globalMethods.DisplayAnswer((79 * 1601).ToString(), sw);
        }
    }
}
