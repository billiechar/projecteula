using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace ProjectEuler {
    class Problem17 {
        public static string Name() {
            return "Number letter counts";
        }

        public static string Description() {
            string val = "If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.";
            val += "\n";
            val += "\n";
            val += "If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?";
            val += "\n";
            val += "\n";
            val += "\n";
            val += "\n";
            val += "NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of \"and\" when writing out numbers is in compliance with British usage.";

            return val;
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            BigInteger letterCount = 0;
            string num = "";

            for (int i = 1; i <= 1000; i++) {
                num += wordarise(i);
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(num.Count().ToString(), sw);
        }

        public static string wordarise(int val) {
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] nums = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string h = "Hundred";
            string a = "And";

            string numWord = "";
            string digits;

            do {
                digits = val.ToString();
                if (val < 20) {
                    numWord += nums[val];
                    val = 0;
                } else if (val < 100) {
                    numWord += tens[int.Parse(digits[0].ToString())];
                    
                    val -= (int.Parse(digits[0].ToString()) * 10);
                } else if (val < 1000) {
                    numWord += nums[int.Parse(digits[0].ToString())] + h;

                    val -= (int.Parse(digits[0].ToString()) * 100);

                    if (val > 0) { numWord += a; }
                } else {
                    numWord = "oneThousand";
                    val = 0;
                }
            } while (val > 0);

            return numWord;
        }
    }
}
