using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler {
    class Problem24 {
        public static string Name() {
            return "Lexicographic permutations";
        }

        public static string Description() {
            string val = "A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:";
            val += "\n";
            val += "\n";
            val += "012   021   102   120   201   210";
            val += "\n";
            val += "\n";
            val += "What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?";
            return val;
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<int> nums = new List<int>();
            nums.Add(0); nums.Add(1); nums.Add(2); nums.Add(3); nums.Add(4); nums.Add(5); nums.Add(6); nums.Add(7); nums.Add(8); nums.Add(9);

            long targetCombination = 1000000;
            long from = 0, to = 0, combinations = Factor(9);
            string perm = "";

            for (int j = 9; j > 0; j--) {
                combinations = Factor(j);
                for (int i = 1; i <= nums.Count; i++) {
                    to = combinations * i;
                    from = combinations * (i - 1);
                    if (from < targetCombination && to >= targetCombination) {
                        perm += nums[i - 1].ToString();
                        nums.RemoveAt(i - 1);
                        targetCombination -= from;
                        i = nums.Count + 1;
                    }
                }
            }

            perm += nums[0];    

            sw.Stop();
            return globalMethods.DisplayAnswer(perm, sw);
        }

        private int Factor(int i) {
            int sum = i;

            for (int n = i - 1; n > 0; n--) {
                sum *= n;
            }

            return sum;
        }
    }
}
