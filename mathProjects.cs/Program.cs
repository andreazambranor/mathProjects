using System;

namespace mathProjects
{
    internal class Program
    {
        static void Main()
        {
            //TITLE
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //PERSON ONE DATA INPUT
            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Enter Hourly Rate:");
            string rateP1 = Console.ReadLine();
            decimal rateP1decimal = Convert.ToDecimal(rateP1);

            Console.WriteLine("Hours worked per week:");
            string hoursP1 = Console.ReadLine();
            decimal hoursP1decimal = Convert.ToDecimal(hoursP1);

            //PERSON TWO DATA INPUT
            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Enter Hourly Rate:");
            string rateP2 = Console.ReadLine();
            decimal rateP2decimal = Convert.ToDecimal(rateP2);

            Console.WriteLine("Hours worked per week:");
            string hoursP2 = Console.ReadLine();
            Decimal hoursP2decimal = Convert.ToDecimal(hoursP2);

            //MATH OPERATION: ANNUAL SALARY OF PERSON 1
            decimal weekSalaryP1 = rateP1decimal * hoursP1decimal;
            decimal annualSalaryP1 = weekSalaryP1 * 52;
            Console.WriteLine("Annual salary of Person 1 is: " + annualSalaryP1);
            Console.ReadLine();

            //MATH OPERATION: ANNUAL SALARY OF PERSON 2
            decimal weekSalaryP2 = rateP2decimal * hoursP2decimal;
            decimal annualSalaryP2 = weekSalaryP2 * 52;
            Console.WriteLine("Annual salary of Person 2 is: " + annualSalaryP2);
            Console.ReadLine();

            //MATH OPERATION: TRUE OR FALSE BOOLEAN
            bool trueOrFalse = annualSalaryP1 > annualSalaryP2;
            Console.WriteLine("Person 1 makes more money than Person 2: " + trueOrFalse.ToString());
            Console.ReadLine();


        }
    }
}
