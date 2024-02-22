using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Common divisors of {0} and {1}:", num1, num2);
        printCommonDivisors(num1, num2);
    }

    static void printCommonDivisors(int num1, int num2)
    {
        int min = Math.Min(num1, num2);

        for (int i = 1; i <= min; i++)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}