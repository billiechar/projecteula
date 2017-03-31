using System;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

namespace ProjectEuler {
    class globalMethods {
        public static string DisplayAnswer(string answer, Stopwatch sw) {
            string[] splitter = sw.Elapsed.ToString().Split(':');
            Clipboard.SetText(answer);

            return answer + " found in " + splitter[2];
        }

        public static int ReadInt32(string value) {
            int val = -1;
            if (!int.TryParse(value, out val)) { return -1; }
            return val;
        }

        public static bool IsPrime(int candidate) {
            if ((candidate & 1) == 0) {
                if (candidate == 2) {
                    return true;
                } else {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= candidate; i += 2) {
                if ((candidate % i) == 0) {
                    return false;
                }
            }
            return candidate != 1;
        }

        public static List<int> divisors(int n) {
            List<int> toreturn = new List<int>();

            for (int i = 1; i <= Math.Floor(Math.Sqrt(n)); i++) {
                if (n % i == 0) {
                    if (toreturn.SingleOrDefault(a => a == i) == 0) { toreturn.Add(i); }
                    if (toreturn.SingleOrDefault(a => a == (n/i)) == 0) { toreturn.Add(n / i); }
                }
            }

            return toreturn;
        }

        public static BigInteger ReadBigInt(string value) {
            BigInteger val = -1;
            if (!BigInteger.TryParse(value, out val)) { return -1; }
            return val;
        }
    }
}
