using System.Diagnostics;

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
                 

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;

                default:
                    break;
            }
        }
    }
}
