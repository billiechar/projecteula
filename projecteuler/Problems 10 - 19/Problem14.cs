
using System.Diagnostics;
namespace ProjectEuler {
    class Problem14 {
        public static string Name() {
            return "Longest Collatz sequence";
        }

        public static string Description() {
            string val = "The following iterative sequence is defined for the set of positive integers:";
            val += "\n";
            val += "\n";
            val += "n → n/2 (n is even)";
            val += "\n";
            val += "n → 3n + 1 (n is odd)";
            val += "\n";
            val += "\n";
            val += "Using the rule above and starting with 13, we generate the following sequence:";
            val += "\n";
            val += "\n";
            val += "13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1";
            val += "\n";
            val += "\n";
            val += "It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.";
            val += "\n";
            val += "\n";
            val += "Which starting number, under one million, produces the longest chain?";
            val += "\n";
            val += "\n";
            val += "NOTE: Once the chain starts the terms are allowed to go above one million.";

            return val;
        }

        public string Answer() {
            int longestSequence = 0;
            int longestSequenceStarter = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 2; i < 1000000; i++) { 
                long term = i;
                int sequenceLength = 1;

                do {
                    if (term % 2 == 0) {
                        term = even(term);
                    } else {
                        term = odd(term);
                    }

                    sequenceLength++;
                } while (term > 1);

                if (sequenceLength > longestSequence) {
                    longestSequence = sequenceLength;
                    longestSequenceStarter = i;
                }    
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(longestSequenceStarter.ToString(), sw);
        }

        private static long even(long n) {
            return (n / 2);
        }

        private static long odd(long n) {
            return ((n * 3) + 1);
        }
    }
}
