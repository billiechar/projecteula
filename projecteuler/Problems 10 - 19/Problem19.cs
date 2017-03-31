using System;
using System.Diagnostics;

namespace ProjectEuler {
    class Problem19 {
        public static string Name() {
            return "Counting Sundays";
        }

        public static string Description() {
            string val = "You are given the following information, but you may prefer to do some research for yourself.";
            val += "\n";
            val += "\n";
            val += "1 Jan 1900 was a Monday.\n";
            val += "Thirty days has September,\n";
            val += "April, June and November.\n";
            val += "All the rest have thirty-one,\n";
            val += "Saving February alone,\n";
            val += "Which has twenty-eight, rain or shine.\n";
            val += "And on leap years, twenty-nine.\n";
            val += "A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.";
            val += "\n";
            val += "\n";
            val += "How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?";
            return val;
        }

        public string Answer() {
            int sundays = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for(int year = 1901; year <= 2000; year++) {
                for (int month = 1; month <= 12; month++) {
                    DateTime date = new DateTime(year, month, 1);
                    if (date.DayOfWeek == DayOfWeek.Sunday) { sundays++; }
                }
            }

            sw.Stop();
            return globalMethods.DisplayAnswer(sundays.ToString(), sw);
        }
    }
}
