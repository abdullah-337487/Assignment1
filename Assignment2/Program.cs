﻿using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum(); //Calling function for Question 01
            //PrintEvenNumbers(); //Calling function for Question 02
            //CheckLeapYear(); //Calling function for Question 03
            //KphToMph(); //Calling function for Question 04
            //CheckBuzz(); //Calling function for Question 05
            //MultiplicationTable1(); //Calling function for Question 06(using while loop)
            //MultiplicationTable2(); //Calling function for Question 06(using for loop)
            //Factorial(); //Calling function for Question 07
            //CheckPrime(); //Calling function for Question 08
            //CheckTriangle(); //Calling function for Question 09
            //pattern(); //Calling function for Question 10
            //CheckPalindrome(); //Calling function for Bonus Question
            CheckPrime(); //Calling function for Question 08
        }
        static void Sum() //Function for Question 01
        {
            Console.Write("Question 01:\nEnter first number: ");
            string userinput1=Console.ReadLine();
            int num1=int.Parse(userinput1);
            Console.Write("Enter second number: ");
            string userinput2 = Console.ReadLine();
            int num2 = int.Parse(userinput2);
            int sum = num1 + num2;
            Console.WriteLine("The sum of two numbers is: " + sum);
        }
        static void PrintEvenNumbers() //Function for Question 02
        {
            Console.Write("Question 02:\n");
            int B = 1;
            while (B <= 100)
            {
                if (B % 2 == 0)
                {
                    Console.WriteLine(B);
                }
                B = B + 1;
            }
        }
        static void CheckLeapYear() //Function for Question 03
        {
            Console.Write("Question 03:\nEnter the year: ");
            string input = Console.ReadLine();
            int year = int.Parse(input);
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("It is a Leap Year!");
                    }
                    else
                    {
                        Console.WriteLine("It is not a Leap Year!");
                    }
                }
                else
                {
                    Console.WriteLine("It is a Leap Year!");
                }
            }
            else
            {
                Console.WriteLine("It is not a Leap Year!");
            }
        }
        static void KphToMph() //Function for Question 04
        {
            Console.Write("Question 04:\nEnter the speed in kilometers per hours: ");
            string input = Console.ReadLine();
            double kph = Convert.ToDouble(input);
            double mph = kph * 0.621371;
            Console.WriteLine (kph+"kph="+ mph+"mph");
        }
        static void CheckBuzz() //Function for Question 05
        {
            Console.Write("Question 5:\nEnter a number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            if (num % 7 == 0)
            {
                Console.WriteLine("It is a Buzz Number!");
            }
            else if (num % 10 == 7)
            {
                Console.WriteLine("It is a Buzz Number!");
            }
            else
            {
                Console.WriteLine("It is not a Buzz Number!");
            }
        }
        static void MultiplicationTable1() //Function for Question 06(using while loop)
        {
            Console.Write("Question 6(using WHILE loop):\nEnter a number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            int i = 1;
            Console.WriteLine("Table of "+num+":");
            while (i <= 10)
            {
                int answer = num * i;
                Console.WriteLine(num+"*"+i+"="+answer);
                i=i + 1;
            }
        }
        static void MultiplicationTable2() //Function for Question 06(using for loop)
        {
            Console.Write("Question 6(using FOR loop):\nEnter a number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            for (int i = 1; i <= 10; i++)
            {
                int answer = num * i;
                Console.WriteLine(num + "*" + i + "=" + answer);
            }
        }
        static void Factorial() //Function for Question 07
        {
            Console.Write("Question 7:\nEnter a number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            int number = num;
            int total = 1;
            while (num >= 1)
            {
                total = total * num;
                num = num - 1;
            }
            Console.WriteLine(number+ "!" + "=" + total);
        }
        static void CheckPrime() //Function for Question 08
        {
            Console.Write("Question 8:\nEnter a number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            bool IsPrime=true;
            if (num % 2 == 0) //Check for even
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        IsPrime = false;
                    }
                    else
                    {
                        IsPrime = true;
                    }
                }
                if (IsPrime == true)
                {
                    Console.WriteLine("It is a Prime Number.");
                }
                else
                {
                    Console.WriteLine("It is not a Prime Number.");
                }
            }
            else //else odd
            {
                for(int q = 2;q <= (num-1)/2;q++)
                {
                    if (num % q == 0)
                    {
                        IsPrime = false;
                    }
                    else
                    {
                        IsPrime = true;
                    }
                }
                if (IsPrime == true)
                {
                    Console.WriteLine("It is a Prime Number.");
                }
                else
                {
                    Console.WriteLine("It is not a Prime Number.");
                }
            }
        }
        static void CheckTriangle() //Function for Question 09
        {
            Console.Write("Question 09:\nEnter the length of first side of triangle: ");
            string input1 = Console.ReadLine();
            double len1 = Convert.ToDouble(input1);
            Console.Write("Enter the length of second side of triangle: ");
            string input2 = Console.ReadLine();
            double len2 = Convert.ToDouble(input2);
            Console.Write("Enter the length of third side of triangle: ");
            string input3 = Console.ReadLine();
            double len3 = Convert.ToDouble(input3);
            if (len1 == len2 && len2 == len3)
            {
                Console.WriteLine("It is Equilateral Triangle.");
            }
            else if (len1 == len2 || len2==len3 || len3==len1)
            {
                Console.WriteLine("It is Isosceles Triangle.");
            }
            else if(len1!=len2 && len2!=len3 && len3!=len1)
            {
                Console.WriteLine("It is Scalene Triangle.");
            }
            else
            {
                
            }
        }
        static void pattern() //Function for Question 10
        {
            Console.Write("Question 10:\nPattern using multiple prints:\n");
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");

            Console.Write("\nPattern using loop:\n");
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void CheckPalindrome() //Function for Bonus Question
        {
            Console.Write("Bonus Question:\nEnter a number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            int Original = num;
            int reversed = 0;
            while (Original > 0)
            {
                int lastdigit = Original % 10;
                reversed=(reversed*10)+lastdigit;
                Original=Original/=10;
            }
            if (reversed == num)
            {
                Console.WriteLine("It is Palindrome number.");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome number.");
            }
        }
    }
}