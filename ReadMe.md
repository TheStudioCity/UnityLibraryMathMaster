# MathMasterLib Unity Library

MathMasterLib is a simple Unity library that provides a collection of mathematical functions. This library is designed to assist Unity developers in performing common mathematical operations within their projects.

## Functions

It provide a number of operations which you can perform such as sum, divide, multiply, modulus, sorting, many more.

# Addition of two numbers

int MathMasterLib.MathMasterLib.Add(int a, int b)
Returns the sum of two numbers.

# Substraction of two numbers 

int MathMasterLib.MathMasterLib.Subtract(int a, int b)
Returns the result of subtracting one number from another.

# Multiplication of two numbers 

int MathMasterLib.MathMasterLib.Multiply(int a, int b)
Returns the product of two numbers.

# Division of two numbers 

float MathMasterLib.MathMasterLib.Divide(float a, float b)
Returns the result of dividing one number by another. Handles division by zero.

# Finding Power

int MathMasterLib.MathMasterLib.Power(int baseNumber, int exponent)
Returns the result of raising a base number to an exponent.

# Modulus of two numbers

int MathMasterLib.MathMasterLib.Modulus(int a, int b)
Returns the remainder of the division of one number by another. Handles modulus by zero.

# SquareRoot of a number 

float MathMasterLib.MathMasterLib.SquareRoot(float a)
Returns the square root of a number. Handles square root of a negative number.

# Factorial of a number 

int MathMasterLib.MathMasterLib.Factorial(int n)
Returns the factorial of a non-negative integer.

# Sum of numbers in a arrays 

int MathMasterLib.MathMasterLib.Sum(params int[] numbers)
Returns the sum of an array of numbers.

# Finding length of a number 

int MathMasterLib.MathMasterLib.GetNumberLength(int number)
Returns the length of a number.

# Convert number to text

string MathMasterLib.MathMasterLib.ConvertNumberToText(int number)
Converts a number into its textual representation.

# Sorting number in ascending order 

int[] MathMasterLib.MathMasterLib.SortAscending(params int[] numbers)
Returns an array of numbers sorted in ascending order.

# Sorting number in descending order 

int[] MathMasterLib.MathMasterLib.SortDescending(params int[] numbers)
Returns an array of numbers sorted in descending order.

## Usage

To use this library in your Unity project, follow these steps:

1) Import the MathMasterLib namespace at the top of your script:

using System;

2) Use the library functions as needed in your scripts.

// Example of using the Add function
int result = MathMasterLib.MathMasterLib.Add(5, 3);
Debug.Log("Add Result: " + result);

3) Explore and leverage the various functions provided by MathMasterLib in your Unity project.

## Examples

Here are a few more examples of using MathMasterLib functions:

// Example of using the Divide function
float result = MathMasterLib.MathMasterLib.Divide(10f, 2f);
Debug.Log("Divide Result: " + result);

// Example of using the Factorial function
int factorialResult = MathMasterLib.MathMasterLib.Factorial(5);
Debug.Log("Factorial Result: " + factorialResult);

// Example of using the SortAscending function
int[] numbers = { 5, 2, 8, 1, 9 };
int[] sortedNumbers = MathMasterLib.MathMasterLib.SortAscending(numbers);
Debug.Log("Sorted Numbers (Ascending): " + string.Join(", ", sortedNumbers));

## Contributing

Contributions are welcome! If you have suggestions, improvements, or bug fixes, feel free to submit a pull request.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details.

## Acknowledgments

Thanks for using MathMasterLib! 
Created by - TheStudioCity!