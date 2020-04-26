using System;

//program
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string name = "Ben Wood";
            string location = "Utah";
            string student = $"My name is {name}, and I am from {location}.";

            //output student
            Console.WriteLine(student);

            //current date - no time
            DateTime currentDate = DateTime.Now;

            //output currentDate
            Console.WriteLine("\nToday's date is " + currentDate.ToString("MM/dd/yyyy"));

            //days until Christmas
            DateTime xmasDay = DateTime.Parse("12/25/2020");
            int daysLeft = (xmasDay - currentDate).Days;

            //output days to Christmas
            Console.WriteLine("\nDays until Christmas: " + daysLeft);

            //GlazerCalc from Yellos Book 2.1
            Console.WriteLine("\n~ Glazer Calculator ~");

            //variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //inputs
            Console.WriteLine("\nEnter Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //calculations
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //outputs
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
