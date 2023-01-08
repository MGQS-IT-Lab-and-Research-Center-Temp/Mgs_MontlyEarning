using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonthlyEarning
{
    public class Salary
    {
        public static double Earning(double hoursOfWork)
        {
            double earningPerDay = 25 * hoursOfWork;
            double earningPerWeek = 5 * earningPerDay;
            double earningPerMonth = 4 * earningPerWeek;
            Console.WriteLine($"Gross money is = {earningPerMonth} dolar");

            if (hoursOfWork > 8 && hoursOfWork <= 24)
            {
                double overTime = (hoursOfWork - 8) * 10;
                double sum = overTime + earningPerDay;
                Console.WriteLine($"Over time money is {sum} dollar");
            }

            if (earningPerMonth <= 1000)
            {
                double minTax = ((double)3 / 200) * earningPerMonth;
                earningPerMonth -= minTax;
                Console.WriteLine($"net amount is{earningPerMonth} dollar");
            
            }

            if (earningPerMonth > 1000 && earningPerMonth < 2500)
            {
                double mediumTax = ((double)5 / 200) * earningPerMonth;
                earningPerMonth -= mediumTax;
                Console.WriteLine($"Net amount is{earningPerMonth}dollar");
            }

            if (earningPerMonth > 2500)
            {
                double maxTax = ((double)9 / 200) * earningPerMonth;
                earningPerMonth -= maxTax;
                Console.WriteLine($"Net earning is = {earningPerMonth}");
            }
            Console.Write($"Amount of money per week in dollar :$");
            return earningPerWeek;



        }

    }
}