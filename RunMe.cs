using System;

namespace csharp_learning
{
    class RunMe
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result Of {0}+{1}= {2}",
                firstNumber, secondNumber, firstNumber + secondNumber);
        }
    }
}
