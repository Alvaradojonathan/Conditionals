using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Age distribution practice
            //Console.WriteLine("Please type your age.");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 2)
            //{
            //    Console.WriteLine("Still in mama's arms");
            //}
            //else if (age >= 3 && age <= 4)
            //{
            //    Console.WriteLine("Preschool Maniac");
            //}
            //else if (age >= 5 && age <= 11)
            //{
            //    Console.WriteLine("Elementary School");
            //}
            //else if (age >= 12 && age <= 14)
            //{
            //    Console.WriteLine("Middle School");
            //}
            //else if (age >= 15 && age <= 18)
            //{
            //    Console.WriteLine("High School");
            //}
            //else if (age >= 19 && age <= 22)
            //{
            //    Console.WriteLine("College");
            //}
            //else if (age >= 23 && age <= 65)
            //{
            //    Console.WriteLine("Working for the man");
            //}
            //else if (age >= 65 && age <= 100)
            //{
            //    Console.WriteLine("The golden years");
            //}

            ////fix this
            //else 
            //{
            //    Console.WriteLine("Youre an alien, this program is for humans");
            //}


            //Word to digit

            //Console.WriteLine("Please type a number between 0 and 10 in lowercase word form");
            //string numberWord = Console.ReadLine();

            //switch (numberWord)
            //{
            //    case "zero":
            //        Console.WriteLine("0");
            //        break;
            //    case "one":
            //        Console.WriteLine("1");
            //        break;
            //    case "two":
            //        Console.WriteLine("2");
            //        break;
            //    case "three":
            //        Console.WriteLine("3");
            //        break;
            //    case "four":
            //        Console.WriteLine("4");
            //        break;
            //    case "five":
            //        Console.WriteLine("5");
            //        break;
            //    case "six":
            //        Console.WriteLine("6");
            //        break;
            //    case "seven":
            //        Console.WriteLine("7");
            //        break;
            //    case "eight":
            //        Console.WriteLine("8");
            //        break;
            //    case "nine":
            //        Console.WriteLine("9");
            //        break;
            //    case "ten":
            //        Console.WriteLine(10);
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;

            //GPA Calc

            //double gradeA = 4.00d;
            //double gradeB = 3.00d;
            //double gradeC = 2.00d;
            //double gradeD = 1.00d;
            //double gradeF = 0.00d;

            //Console.WriteLine("How many classes did you take?");
            //double classesTaken = double.Parse(Console.ReadLine());

            //Console.WriteLine("How many A's did you receive?");
            //double totalA = double.Parse(Console.ReadLine());

            //Console.WriteLine("How many B's did you receive?");
            //double totalB = double.Parse(Console.ReadLine());

            //Console.WriteLine("How many C's did you receive?");
            //double totalC = double.Parse(Console.ReadLine());

            //Console.WriteLine("How many D's did you receive?");
            //double totalD = double.Parse(Console.ReadLine());

            //Console.WriteLine("How many F's did you receive?");
            //double totalF = double.Parse(Console.ReadLine());

            //double gpa = Math.Round(((totalA * gradeA) + (totalB * gradeB) + (totalC * gradeC) + (totalD * gradeD) + (totalF * gradeF)) / classesTaken, 2);
            //Console.WriteLine("GPA is: " + gpa);

            //Write a console application to ask the user for two integers. Check and see if the two
            //integers are equal to each other.If they are, inform the the user that the numbers are
            //equal, else inform the user that the numbers are not equal
            //Input:Enter your first number 16
            //Input: Enter your second number: 18
            //Output: The numbers 16 and 18 are not equal to each other
            //Input: Enter your first number: 25
            //Input: Enter your second number: 25
            //Output: The numbers 25 and 25 are the same number

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Enter your first number: ");
            //double firstNumber = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your second number: ");
            //double secondNumber = double.Parse(Console.ReadLine());

            //if (secondNumber == firstNumber)
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not the same.");
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //2.Write a console application that asks the user for a number. Tell the user if that number
            //is even or odd.
            //Input: 15
            //Output: 15 is an odd number
            //Input: 116
            //Output: 116 is an even number

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Enter a number: ");
            //double number = double.Parse(Console.ReadLine());

            //if ((number % 2) == 0)
            //{
            //    Console.WriteLine(number + " is even.");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is odd.");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //3.Write a console application that asks the user for a number and tells them if that number
            //is a positive or negative number. What happens when the user enters 0 ? Is it positive or
            //negative?
            //Input: -24
            //Output: The number -24 is a negative number
            //Input: 545
            //Output: The number 545 is a positive number

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Enter any positive or negative number: ");
            //double number = double.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    Console.WriteLine(number + " is positive");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine(number + " is negative.");
            //}
            //else
            //{
            //    Console.WriteLine(number + " has no value.");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //4.Write a console application to check whether a letter is a vowel or consonant.Extra:
            //You can do this problem using a switch or an if condition.
            //Input: a
            //Output: That letter a is a vowel
            //Input: c
            //Output: The letter c is a consonant
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("enter any one lowercase letter:");
            //char letter = char.Parse(Console.ReadLine());

            //switch (letter)
            //{
            //    case 'a':
            //        Console.WriteLine(letter + " is a vowel.");
            //        break;
            //    case 'e':
            //        Console.WriteLine(letter + " is a vowel.");
            //        break;
            //    case 'i':
            //        Console.WriteLine(letter + " is a vowel.");
            //        break;
            //    case 'o':
            //        Console.WriteLine(letter + " is a vowel.");
            //        break;
            //    case 'u':
            //        Console.WriteLine(letter + " is a vowel.");
            //        break;
            //    default:
            //        Console.WriteLine(letter + " is a consonant.");
            //        break;
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //5.Write a console application that prompts the user to input two integer values. Find and
            //print the greatest value of the two integers.
            //Input: Enter your first number 25
            //Input: Enter your second number -25
            //Output: 25 is the biggest number
            //*Bonus ask the user for 3 numbers and find the greatest value between those 3
            //numbers

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Enter a number:");
            //double firstNumber = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a number:");
            //double secondNumber = double.Parse(Console.ReadLine());

            //if (firstNumber > secondNumber)
            //{
            //    Console.WriteLine(firstNumber + " is the larger number.");
            //}
            //else if (firstNumber < secondNumber)
            //{
            //    Console.WriteLine(secondNumber + " is the larger number.");
            //}
            //else
            //{
            //    Console.WriteLine(firstNumber + " and " + secondNumber + " are the same.");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //6.Write a Console application that asks the user for 4 integers.Calculate the mean​ for
            //these 4 numbers and display the result.
            //Console.WriteLine("Enter any whole numbers four times");
            //Console.WriteLine("First number:");
            //double firstNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Second number:");
            //double secondNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Third number:");
            //double thirdNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("Fourth number:");
            //double fourthNum = double.Parse(Console.ReadLine());

            //double mean = Math.Round(((firstNum + secondNum + thirdNum + fourthNum) / 4),2);
            //Console.WriteLine("The mean for: " + firstNum+ ", "+ secondNum + ", " + thirdNum + ", " + fourthNum + " is " + mean);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Mini FizzBuzz Problem (Final Jeopardy Problem)
            //Ask the user for 2 numbers.One number will be the FIZZ number and one number will be the BUZZ number.
            //When you run the program, a user should be able to enter a test number.
            //If the test number is a multiple of the FIZZ number, print "Fizz!".
            //If the test number is a multiple of the BUZZ number, print "Buzz!".
            //If the test number is a multiple of the FIZZ and BUZZ numbers, print "FizzBuzz!".
            //If the test number is NOT a multiple of the FIZZ or BUZZ numbers, print the test number.

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter a number between 1 and 9:");
            int fizz = int.Parse(Console.ReadLine());
            while (fizz < 1 || fizz > 9)
            {
                Console.WriteLine("You didn't follow directions.");
                Console.WriteLine("Enter a number between 1 and 9:");
                fizz = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter a number between 1 and 9:");
            int buzz = int.Parse(Console.ReadLine());
            while (buzz < 1 || buzz > 9)
            {
                Console.WriteLine("You didn't follow directions.");
                Console.WriteLine("Enter a number between 1 and 9:");
                buzz = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter any number:");
            int test = int.Parse(Console.ReadLine());


            if (test % fizz == 0 && test % buzz == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (test % buzz == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (test % fizz == 0)
            {
                Console.WriteLine("Fizz");
            }

            else
            {
                Console.WriteLine(test);
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
