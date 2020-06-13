using System;
using System.Linq;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            problem1();

            Console.Clear();

            Problem2();

            Console.Clear();

            Problem3();

            Console.Clear();
            */

            Problem4();

        }

        private static void problem1()
        {
            // Request 5 numbers from 1-10 from the user:

            Console.Write("Please select five numbers between 1-10:");

            string userValues = Console.ReadLine();

            //Another option to convert the whole string
            //int userString = Convert.ToInt32(userValues);

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
            Console.ReadLine();
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
            //Console.WriteLine($"The sum of all numbers: {sumArray}");

            //Loop through the array to get the product of all the numbers:

            for (int i = 0; i < numArray.Length; i++)
            {
                productArray *= numArray[i];
            }
            //Console.WriteLine($"The product of all numbers: {productArray}");

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
            Console.ReadLine();
        }

        private static void Problem4()
        {
            //TODO - ask the user for the array input? 

            //Defining and initializing a multidimentional array, with the sample array:

            int[,] myArray = new int[3, 5] {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };

            Console.WriteLine(myArray.GetLength(0));
            Console.WriteLine(myArray.GetLength(1));

            //Defining global variables:
            

            //Defining sumArray, an integer array of all the row sums:
            int[] sumArray = new int[myArray.GetLength(0)];

            //Nested for statement? Access the first row of the array, loop through it and sum the numbers:

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    //calculate sum of row
                    //Insert row sum into sumArray
                    rowSum += myArray[i,j];

                }
                sumArray[i] = rowSum;

            }


            string returnString = String.Join(",", sumArray.Select(p => p.ToString()).ToArray());
;

            Console.WriteLine(returnString);
        }
    }
}
