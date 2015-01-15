using System;

 class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Enter your DAY of birth /dd format");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your MONTH of birth /mm format");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your YEAR of birth /yyyy format");
            int year = int.Parse(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);
            int age = DateTime.Now.Year - birthday.Year;

            Console.WriteLine("You are now {0} years old and you are going to be {1} years old after 10 years!", age, age + 10);
        }
    }