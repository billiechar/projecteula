using System.Diagnostics;

namespace ProjectEuler {
    class Problem67 {
        public static string Name() {
            return "Maximum path sum I";
        }

        public static string Description() {
            return "By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.\n\nThat is, 3 + 7 + 4 + 9 = 23.\n\nFind the maximum total from top to bottom of the triangle below:";
        }

        private static int limit = 100;

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[,] triangle = new int[limit, limit];
            string numberString = System.IO.File.ReadAllText(@"C:\triangle.txt");
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
