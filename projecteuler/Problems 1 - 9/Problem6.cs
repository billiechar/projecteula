
using System.Diagnostics;
namespace ProjectEuler {
    class Problem6 {
        public static string Name() {
            return "Sum Square Difference";
        }

        public static string Description() {
            string val = "The sum of the squares of the first ten natural numbers is,";
            val += "\n\n";
            val += "12 + 22 + ... + 102 = 385";
            val += "\n\n";
            val += "The square of the sum of the first ten natural numbers is,";
            val += "\n\n";
            val += "(1 + 2 + ... + 10)2 = 552 = 3025";
            val += "\n\n";
            val += "Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.";
            val += "\n\n";
            val += "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";

            return val;
        }

        public string Answer() {
            int i, square, sumOfSquare = 0, sum = 0, result;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (i = 1; i <= 100; i++) {
                square = i * i;
                sumOfSquare += square;

                sum += i;
            }

            sum *= sum;

            if (sum > sumOfSquare) {
                result = sum - sumOfSquare;
            } else {
                result = sumOfSquare - sum;
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(result.ToString(), sw);
        }
    }
}
