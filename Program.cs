using System;

namespace BillsPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            var montlyWage = 1234;
            int months = 12, bonus = 1000;

            var isActive = true;
            var  rating = 99.25;

            //montlyWage = true;
            
            double ratePerHour = 12.34;
            int numberOfHoursWorked = 165;

            long veryLongMonth = numberOfHoursWorked;
            //double d = 123456789.0
            int x = (int)d;

            int intVeryLongMonth = (int)veryLongMonth; 

            double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

            Console.WriteLine(currentMonthWage);

            ratePerHour += 3; //ratePerHour = ratePerHour +3;

            if (currentMonthWage > 2000)
            {
                Console.WriteLine("Top paid employee");
            }
            int numberOfEmployees = 15;
            numberOfEmployees--;

            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;

            char userSelction = 'a';
            char upperVersion = char.ToUpper(userSelction);
            bool isDigit = char.IsDigit(userSelction);
            bool isLetter = char.IsLetter(userSelction);

            DateTime hireDate = new DateTime(2021, 3, 28, 14, 30, 0);

            Console.WriteLine(hireDate);

            //DateTime exitDate = new DateTime(2021, 15, 11);

            DateTime startDate = hireDate.AddDays(15);

            Console.WriteLine(startDate);

            DateTime currentDate = DateTime.Now;
            bool areWeInDST = currentDate.IsDaylightSavingTime();

            DateTime startHour = DateTime.Now;
            TimeSpan worktime = new TimeSpan(8, 35, 0);
            DateTime endHour = startHour.Add(worktime);

            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(endHour.ToLongDateString());




            Console.ReadLine();
        }
    }
}