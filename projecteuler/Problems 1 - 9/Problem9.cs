using System;
using System.Diagnostics;

namespace ProjectEuler {
    class Problem9 {
        public static string Name() {
            return "Special Pythagorean triplet";
        }

        public static string Description() {
            string val = "A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,";
            val += "\n\n";
            val += "a2 + b2 = c2";
            val += "\n\n";
            val += "For example, 32 + 42 = 9 + 16 = 25 = 52.";
            val += "\n\n";
            val += "There exists exactly one Pythagorean triplet for which a + b + c = 1000.\nFind the product abc.";
            return val;
        }

        public string Answer() {
            int a = 0, b = 0, aSquared, bSquared;
            double c = 0, cSquared, product;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            do {
                a++;
                aSquared = a * a;
                b = a;

                do {
                    b++;
                    bSquared = b * b;
                    cSquared = aSquared + bSquared;
                    c = Math.Sqrt(cSquared);
                } while ((a + b + c) < 1000);
            } while (a + b + c != 1000);

            product = a * b * c;

            sw.Stop();
            return globalMethods.DisplayAnswer(product.ToString(), sw);
        }
    }
}
