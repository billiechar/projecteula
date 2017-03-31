
using System.Diagnostics;
namespace ProjectEuler {
    class Problem4 {
        public static string Name() {
            return "Largest Palindrome Product";
        }

        public static string Description() {
            string val = "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.";
            val += "/n/n";
            val += "Find the largest palindrome made from the product of two 3-digit numbers.";
            return val;
        }

        public string Answer() {
            int result = 0;
            string resultText;
            string left;
            string right;
            int highestPalindrome = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int n = 999; n > 99; n--) { 
                for (int i = 999; i > 99; i--) {
                    result = n * i;

                    resultText = result.ToString();

                    left = resultText.Substring(0, 3);
                    right = resultText.Substring(3);

                    char[] splitter = left.ToCharArray();

                    left = splitter[2].ToString() + splitter[1].ToString() + splitter[0].ToString();

                    if (left == right) {
                        if (result > highestPalindrome) {
                            highestPalindrome = result;       
                        }
                    }
                }
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(highestPalindrome.ToString(), sw);
        }
    }
}
