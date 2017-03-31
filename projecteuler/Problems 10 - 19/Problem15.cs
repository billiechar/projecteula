using System;
using System.Diagnostics;

namespace ProjectEuler {
    class Problem15 {
        public static string Name() {
            return "Lattice paths";
        }

        public static string Description() {
            return "Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.\n\nHow many such routes are there through a 20×20 grid?";
        }

        public string Answer() {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Int64[,] paths = new Int64[21, 21];
 
            for (int row = 0; row <= 20; row++)
            {
                for (int column = 0; column <= 20; column++)
                {
                    if (row == 0 || column == 0)
                        paths[row, column] = 1;
                    else
                        paths[row, column] = paths[row - 1, column] + paths[row, column - 1];
                }
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(paths[20, 20].ToString(), sw);
        }
    }
}
