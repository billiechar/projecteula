﻿
using System.Diagnostics;
namespace ProjectEuler {
    class Problem18 {
        public static string Name() {
            return "Maximum path sum I";
        }

        public static string Description() {
            return "By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.\n\nThat is, 3 + 7 + 4 + 9 = 23.\n\nFind the maximum total from top to bottom of the triangle below:";
        }

        private static int limit = 15;

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[,] triangle = new int[limit, limit];
            string numberString = "75 95 64 17 47 82 18 35 87 10 20 04 82 47 65 19 01 23 75 03 34 88 02 77 73 07 63 67 99 65 04 28 06 16 70 92 41 41 26 56 83 40 80 70 33 41 48 72 33 47 32 37 16 94 29 53 71 44 65 25 43 91 52 97 51 14 70 11 33 28 77 73 17 78 39 68 17 57 91 71 52 38 17 14 91 43 58 50 27 29 48 63 66 04 68 89 53 67 30 73 16 69 87 40 31 04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
            numberString = numberString.Replace("\n", " ");
            string[] numbers = numberString.Split(' ');
            int item = 0;
            int n, i;

            for (i = 0; i < limit; i++) {
                for (n = 0; n <= i; n++) {
                    triangle[i, n] = int.Parse(numbers[item]);
                    item++;
                }
            }

            n = 0;
            i = limit - 1;
            int j = 0;
            int[] newLine = getLine(triangle, i);

            do {
                int prevNum = getNum(triangle, i - 1, n);
                int opt1, opt2;

                opt1 = prevNum + newLine[n];
                opt2 = prevNum + newLine[n + 1];

                newLine[j] = highestInt(opt1, opt2);
                n++;
                j++;

                if (n == limit - 1) {
                    n = 0;
                    j = 0;
                    i--;
                }
            } while (i > 0);

            sw.Stop();
            return newLine[0].ToString() + " - " + sw.Elapsed;
        }

        private static int[] getLine(int[,] triangle, int line) {
            int[] newLine = new int[limit];

            for (int i = 0; i < limit; i++) {
                newLine[i] = triangle[line, i];
            }

            return newLine;
        }

        private static int getNum(int[,] triangle, int line, int col) {
            return triangle[line, col];
        }

        private static int highestInt(int val1, int val2) {
            if (val1 > val2)
                return val1;
            return val2;
        }
    }
}
