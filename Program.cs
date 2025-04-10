using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Function
{
    internal class Program
    {

        public static String EvenOrOdd(int number)
        {
            int result;

            if (number % 2 == 0)
                return "Even number";
            else
                return "Odd number";
        }
        public static int LargestOfThreeNumbers(int num1, int num2 , int num3)
        {
            int result2;
  
            if (num1 > num2 && num1 >num3 )
                    return num1;
              
            else if (num2 > num1 && num2 > num3)
                return num2;
            
            else
                return num3;
        
        }
        public static double TemperatureConverter(double celsius)
        {
            double fahrenheit;
            double result3;

            fahrenheit= (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public static double SimpleDiscountCalculator(double price)
        {
            double discount = 0;
            double finalPrice;

            if (price > 100)
            {
                discount = (price / 100) * 10;
                finalPrice = price - discount;
                return finalPrice;
            }

            else
                return price;
      
        }

        public static char GradingSystem(int mark)
        {

            char grade;

            if (mark >= 90)
                grade = 'A';
            else if (mark >= 80)
                grade = 'B';
            else if (mark >= 70)
                grade = 'C';
            else if (mark >= 60)
                grade = 'D';
            else
                grade = 'F';
            return grade;
        }

        public static String SwapTwoNumbers(int num1, int num2)
        {
            int swap;

            swap = num1;
            num1 = num2;
            num2 = swap;
            string Output = "First Number is = " + num1 + ", Second Number is = " + num2;
            return Output; 
        }

        public static String DaysToWeeksAndDaysConverter(int days)
        {
            int weeks = days / 7;
            int remainingDays = days % 7;

            string Output = days + " days = " + weeks + " week(s) and " + remainingDays + " day(s)";
            return Output;
        }

        public static String ElectricityBillCalculator(int NumberUnitsConsume)
        {
            string massage;
            double ElectricityBill;

            if (NumberUnitsConsume <= 100)
            {
                ElectricityBill = NumberUnitsConsume * 0.5;
                massage = "The Electricity Bill is: " + ElectricityBill;

            }

            else if (NumberUnitsConsume >= 101 && NumberUnitsConsume <= 300)
            {
                ElectricityBill = NumberUnitsConsume * 0.75;
                massage = "The Electricity Bill is: " + ElectricityBill;
            }

            else
            {
                ElectricityBill = NumberUnitsConsume * 1;
                massage = "The Electricity Bill is: " + ElectricityBill;

            }
            return massage;
        }

        public static String SimpleCalculator(double FirstNumber, double SecondNumber, char operation)
        {
           
            double result = 0;

            if (operation == '+')
                result = FirstNumber + SecondNumber;
            else if (operation == '-')
                result = FirstNumber - SecondNumber;
            else if (operation == '*')
                result = FirstNumber * SecondNumber;
            else if (operation == '/')
            {
                if (SecondNumber != 0)
                    result = FirstNumber / SecondNumber;
                else
                {
                    return "Cannot divide by zero!";
                }
            }
            else 
                return "Invalid operator";

            string Output = "Result: " + result;
            return Output;
        }


        public static void printValue(string input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program menu \n 1. Even or Odd  \n 2. Largest of Three Numbers \n 3. Temperature Converter \n 4. Simple Discount Calculator \n 5. Grading System \n 6. Swap Two Numbers \n 7. Days to Weeks and Days Converter \n 8. Electricity Bill Calculator \n 9. Simple Calculator ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter 2 numbers");
                    int number = int.Parse(Console.ReadLine());
                    string result = EvenOrOdd(number);
                    printValue(result);
                    break;

                case 2:
                    Console.Write("Enter first number: ");
                    int num1 = int.Parse(Console.ReadLine());
       
                    Console.Write("Enter second number: ");
                    int num2 = int.Parse(Console.ReadLine());
                  
                    Console.Write("Enter thired number: ");
                    int num3 = int.Parse(Console.ReadLine());

                    int result2 = LargestOfThreeNumbers( num1, num2, num3);
                    printValue(result2.ToString()); ;
                    break;

                case 3:
                    Console.Write("Enter temperature in Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());

                    double result3 = TemperatureConverter(celsius);
                    printValue(result3.ToString()); 
                    break;

                case 4:
                    Console.Write("Enter the price of the item: ");
                    double price = double.Parse(Console.ReadLine());

                    double result4 = SimpleDiscountCalculator(price);
                    printValue(result4.ToString());
                    break;

                case 5:
                    Console.Write("Enter student score: ");
                    int mark = int.Parse(Console.ReadLine());

                    char result5 = GradingSystem(mark);
                    printValue(result5.ToString());
                    break;
                case 6:
                  
                    Console.Write("Enter first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = int.Parse(Console.ReadLine());

                    string result6 = SwapTwoNumbers( num1, num2);
                    printValue(result6);
                    break;
                case 7:

                    Console.Write("Enter number of days: ");
                    int days = int.Parse(Console.ReadLine());

                    string result7 = DaysToWeeksAndDaysConverter(days);
                    printValue(result7);
                    break;
                case 8:

                   
                    Console.WriteLine("Enter the number of units consume :\n");
                    int NumberUnitsConsume = int.Parse(Console.ReadLine());

                    string result8 = ElectricityBillCalculator(NumberUnitsConsume);
                    printValue(result8);

                    break;
                case 9:

                    Console.Write("Enter first number: ");
                    double FirstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Enter operator (+, -, *, /): ");
                    char operation = Console.ReadKey().KeyChar;

                    Console.Write("Enter second number: ");
                    double SecondNumber = double.Parse(Console.ReadLine());

                    string result9 = SimpleCalculator(FirstNumber, SecondNumber, operation);
                    printValue(result9);

                    break;

                default:
                    break;
            }
        }
    }
}
