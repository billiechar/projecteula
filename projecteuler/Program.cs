using System;
using System.Numerics;
using System.Reflection;

namespace ProjectEuler {
    class Program {

        [STAThread]
        static void Main(string[] args) {
            BigInteger res = 1000000000 * 7000000000;
            Console.Write(res);

            int problemCount = 0, problemTens, i, problem = 0, problemStart, problemFinish;

            Type type;

            do {
                problemCount++;
                type = Type.GetType("ProjectEuler.Problem" + problemCount);
            } while (type != null);

            problemCount--;

            do {
                Console.WriteLine("\n------------------------------");
                Console.WriteLine("Project Euler - Problems");
                Console.WriteLine("------------------------------\n");

                if (problemCount > 10) {
                    int tens = problemCount /10;
                    for (i = 0; i <= tens; i++) {
                        if (i == 0) { 
                            Console.WriteLine("1: Problems 1 to 9");
                        } else if(i == tens) {
                            Console.WriteLine("{0}: Problems {1} to {2}", i + 1, (i * 10), problemCount);
                        } else {
                            Console.WriteLine("{0}: Problems {1} to {2}", i + 1, (i * 10), (i * 10) + 9);
                        }
                    }
                }

                problem = 0;
                problemTens = (problemCount / 10) + 1;
                do {
                    Console.Write("\nPick a group of problems from 1 to " + problemTens + ": ");
                    problem = globalMethods.ReadInt32(Console.ReadLine());
                } while (problem < 1 || problem > problemTens);

                problemStart = (problem - 1) * 10;
                problemFinish = ((problem - 1) * 10) + 9;

                if (problemStart == 0) { problemStart = 1; }
                if (problemFinish > problemCount) { problemFinish = problemCount; }

                for (i = problemStart; i <= problemFinish; i++) {
                    Console.WriteLine("{0}. {1}", i, caller("ProjectEuler.Problem" + i, "Name"));
                }

                problem = 0;
                do {
                    Console.Write("\nPick a problem from {0} to {1}: ", problemStart, problemFinish);
                    problem = globalMethods.ReadInt32(Console.ReadLine());
                } while (problem < problemStart || problem > problemFinish);

                Console.WriteLine("\n------------------------------");
                Console.WriteLine(caller("ProjectEuler.Problem" + problem, "Name"));
                Console.WriteLine("\n" + caller("ProjectEuler.Problem" + problem, "Description"));

                string answer = caller("ProjectEuler.Problem" + problem, "Answer");

                Console.WriteLine("\nAnswer: " + answer);
                Console.WriteLine("------------------------------\n");
                Console.Write("Answer sent to clipboard. Press any key to return to menu...");
                Console.ReadKey();
                Console.WriteLine("\n");
            } while (true);
        }

        private static string caller(string _class, string _method) {
            try { 
                Type type = Type.GetType(_class);
                object obj = Activator.CreateInstance(type);
                MethodInfo info = type.GetMethod(_method);

                return (String)info.Invoke(obj, null);
            } catch (Exception ex) {
                return "";
            }
        }
    }
}
