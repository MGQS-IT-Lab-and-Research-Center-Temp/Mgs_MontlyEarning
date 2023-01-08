using System;

namespace MonthlyEarning
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input no of hour(s) of work");
                double hoursOfWork = Double.Parse(Console.ReadLine());

              
                if (hoursOfWork >= 15)
                {
                    hoursOfWork = 15;
                }
                else
                {
                    double hour = Salary.Earning(hoursOfWork);
                    Console.WriteLine(hour);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }     
    }
}
