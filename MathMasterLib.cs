using System;
using System.Linq;

namespace MathMasterLib
{
public static class MathMasterLib
{
    // Add two numbers
    public static int Add(int a, int b)
    {
        return a + b;
    }

	// Subtract two numbers
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

	// Multiply two numbers
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

	// Divide two numbers
    public static float Divide(float a, float b)
    {
        if (b != 0)
            return a / b;
        else
        {
            // Handle division by zero
            return float.MaxValue;
        }
    }

    // Power 
    public static int Power(int baseNumber, int exponent)
    {
        return (int)Math.Pow(baseNumber, exponent);
    }

	// Modulus
    public static int Modulus(int a, int b)
    {
        if (b != 0)
            return a % b;
        else
        {
            // Handle modulus by zero
            return int.MaxValue;
        }
    }

	// SquareRoot
    public static float SquareRoot(float a)
    {
        if (a >= 0)
            return (float)Math.Sqrt(a);
        else
        {
            // Handle square root of a negative number
            return float.NaN;
        }
    }

    // Factorial
    public static int Factorial(int n)
    {
        if (n < 0)
        {
            // Handle negative input
            return -1;
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }

        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

	// Sum of array
    public static int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }

    // Length
    public static int GetNumberLength(int number)
    {
        return Math.Abs(number).ToString().Length;
    }

	// Number to Text
    public static string ConvertNumberToText(int number)
    {
        // Convert a number into its textual representation (e.g., 1 = "one")
        if (number >= 0 && number <= 9)
        {
            string[] numberTexts = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            return numberTexts[number];
        }
        else
        {
            // Handle out-of-range numbers
            return "Out of range";
        }
    }

   // Sorting
	public static int[] SortAscending(params int[] numbers)
	{
		int[] sortedNumbers = new int[numbers.Length];
		Array.Copy(numbers, sortedNumbers, numbers.Length);
		Array.Sort(sortedNumbers);
		return sortedNumbers;
	}

	public static int[] SortDescending(params int[] numbers)
	{
		int[] sortedNumbers = new int[numbers.Length];
		Array.Copy(numbers, sortedNumbers, numbers.Length);
		Array.Sort(sortedNumbers);
		Array.Reverse(sortedNumbers);
		return sortedNumbers;
	}
}
}