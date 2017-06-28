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

            Console.WriteLine("Please type a number between 0 and 10 in lowercase word form");
            string numberWord = Console.ReadLine();

            switch (numberWord)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine(10);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
