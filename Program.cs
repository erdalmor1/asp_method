using System;

namespace MethodDemo
{
    // This class demonstrates a method with two integer parameters
    public class Calculator
    {
        // This method performs modulo operation on the first parameter and displays the second parameter
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Calculate the remainder when first number is divided by 3
            int result = firstNumber % 3;
            
            // Display both the calculation result and the second parameter
            Console.WriteLine($"First number {firstNumber} % 3 = {result}");
            Console.WriteLine($"Second number is: {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calc = new Calculator();

            // Call the method using positional parameters
            Console.WriteLine("Calling method with positional parameters:");
            calc.ProcessNumbers(8, 16);

            Console.WriteLine("\nCalling method with named parameters:");
            // Call the method using named parameters
            calc.ProcessNumbers(firstNumber: 11, secondNumber: 22);

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}