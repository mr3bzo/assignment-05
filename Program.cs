

using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.ComponentModel;

namespace assignment_05
    {
    static class Program {
        static void Main(string[] args)
        {

            // Value type 
            // by value msh bt8air el orginal value 
            // by referance bt8air el orginal value 


            // referance type 
            // by referance msh btt8air 

            // by value bt8air 
            #region ex01
            //    // Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.


            //    static void PassByValue(int x)
            //    {   
            //        x = 20;                                                 // Changes only affect local copy
            //        Console.WriteLine("Inside function: " + x);             // Shows 20
            //    }

            //    static void PassByReference(ref int x)
            //    {
            //        x = 20;                                                 // Changes affect original variable
            //        Console.WriteLine("Inside function: " + x);             // Shows 20
            //    }

            //    static void Main()
            //    {
            //        int num1 = 10;
            //        int num2 = 10;

            //        Console.WriteLine("Before PassByValue: " + num1);    // Shows 10
            //        PassByValue(num1);
            //        Console.WriteLine("After PassByValue: " + num1);     // Still 10

            //        Console.WriteLine("\nBefore PassByRef: " + num2);    // Shows 10
            //        PassByReference(ref num2);
            //        Console.WriteLine("After PassByRef: " + num2);       // Changed to 20

            #endregion
            #region 02
            // Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.


            //static void PassByValue(int[] arr)
            //{
            //    arr[0] = 20;  // Changes original array
            //    arr = new int[] { 30, 40, 50 };  // Only changes local copy
            //}

            //static void PassByReference(ref int[] arr)
            //{
            //    arr[0] = 20;  // Changes original array
            //    arr = new int[] { 30, 40, 50 };  // Changes original array reference
            //}

            //static void Main()
            //{
            //    int[] array1 = { 1, 2, 3 };
            //    int[] array2 = { 1, 2, 3 };

            //    PassByValue(array1);
            //    // array1 is now {20, 2, 3}

            //    PassByReference(ref array2);
            //    // array2 is now {30, 40, 50}




            //                Both methods allow you to:

            //Access the array elements
            //Modify the array contents
            //Work with the same data in memory


            //Only 'ref' allows you to:

            //Change which array the original variable points to
            //Reassign the entire array
            //Affect the original reference itself

            #endregion
            #region 03
            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers


            //static void Calculate(int a, int b, int c, int d)
            //{
            //    int sum = a + b + c + d;
            //    int subtract = a - b - c - d;
            //    Console.WriteLine( sum);
            //    Console.WriteLine( subtract);
            #endregion
            #region 04
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.


            // x 
            //int X;


            //static void calculatedigits (X) {
            //    int[] Y;
            //    for (int i=0; i< X; i++)
            //    {
            //        Y += i;


            //    }
            //    Console.WriteLine(Y);

            //}



            #endregion

            #region 05

            // Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            // 1- 7a3ml funcation is prime 
            //2-7adlha num mn el user 
            //-3 lw el rakam !% 2 $$ !%3 return is prime 


            Console.Write("Input number: ");
            int num = int.Parse(Console.ReadLine());


            static bool IsPrime(int num)
            {

                if (num == 2)
                    return true;


                if (num < 2)
                    return false;


                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                        return false;
                }

                return true;
            }
            #endregion

            #region 06
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //   public static int MinMaxArray(int[] arr ,ref  int min , ref int max )
            //{
            //    min = arr[0];
            //    max = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] < min) min = arr[i];
            //        if (arr[i] > max) max = arr[i];

            //    }



            //    }



            #endregion
            #region 07


            #endregion

            #region 08
            // Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter


            //static string ChangeChar(string text, int position, char newChar)
            //{
            //    if (position < 0 || position >= text.Length)
            //    {
            //        return text;  // Return unchanged if position is invalid
            //    }

            //    char[] letters = text.ToCharArray();
            //    letters[position] = newChar;
            //    return new string(letters);
            //}


            #endregion







        }
    }
               }