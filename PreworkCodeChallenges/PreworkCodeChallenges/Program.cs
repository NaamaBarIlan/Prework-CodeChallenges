using System;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            problem1();

            Problem2();

            Problem3();

        }

        private static void problem1()
        {
            // Request 5 numbers from 1-10 from the user:

            Console.Write("Please select one numbers between 1-10:");

            string userValues = Console.ReadLine();

            // Declare and initialize an array with the user's input, converted from char to double:
            // QUESTION - why couldn't I convert from char to int? Could I refactor this part?

            double[] numbersArray = new double[5];
                numbersArray[0] = char.GetNumericValue(userValues[0]);
                numbersArray[1] = char.GetNumericValue(userValues[1]);
                numbersArray[2] = char.GetNumericValue(userValues[2]);
                numbersArray[3] = char.GetNumericValue(userValues[3]);
                numbersArray[4] = char.GetNumericValue(userValues[4]);

            // Clear the screen:
            Console.Clear();

            // Ask the user to select a number from the array:
            Console.WriteLine($"Now select one number out of your five numbers: " +
                $"{numbersArray[0]}," +
                $"{numbersArray[1]}," +
                $"{numbersArray[2]}," +
                $"{numbersArray[3]}," +
                $"{numbersArray[4]}");

            // Convert the user input from string to an int: 
            int selectedNum = Convert.ToInt32(Console.ReadLine());

            // Output the "score" of the chosen number: chosen number *  frequency of chosen number in the array:
            int numFrequncy = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == selectedNum)
                {
                    numFrequncy++;
                }
            }

            int numScore = selectedNum * numFrequncy;

            Console.WriteLine("The score of the number you selected is " + numScore);          
        }

        private static void Problem2()
        {
            Console.WriteLine("Type in a year to find out if it's a leap year: ");
            int inputYear = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (inputYear % 4 == 0 && inputYear % 100 != 0)
            {
                Console.WriteLine($"Yes, {inputYear} is a leap year!");

            }
            else if (inputYear % 4 == 0 && inputYear % 100 == 0 && inputYear % 400 == 0)
            {
                Console.WriteLine($"Yes, {inputYear} is a leap year!");

            }
            else
            {
                Console.WriteLine($"Sadly, {inputYear} is not a leap year.");
            }
        }

        private static void Problem3()
        {
            //TODO - need to ask the user for the array input? 

            //Defining and initializing an array, with the sample array to start:
            int[] numArray = new int[] { 1, 3, 2 };

            //Defining global variables:
            string message = "";
            bool nonNegative = true;
            int sumArray = 0;
            int productArray = 1;

            //Loop through the array to check all numbers are non-negative:

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < 0)
                {
                    nonNegative = false;
                    //Console.WriteLine(nonNegative);
                    break;
                }
            }

            //Loop through the array to get the sum of all the numbers:

            for (int i = 0; i < numArray.Length; i++)
            {
                sumArray += numArray[i];
            }
            Console.WriteLine($"The sum of all numbers: {sumArray}");

            //Loop through the array to get the product of all the numbers:

            for (int i = 0; i < numArray.Length; i++)
            {
                productArray *= numArray[i];
            }
            Console.WriteLine($"The product of all numbers: {productArray}");

            //If statement for a Yes/No return:
            //If all the numbers are non-negative && sum == product return Yes, else return "No"

            if (nonNegative && sumArray == productArray)
            {
                message = "Yes";

            }
            else
            {
                message = "No";
            }
            Console.WriteLine(message);
        }
    }
}
