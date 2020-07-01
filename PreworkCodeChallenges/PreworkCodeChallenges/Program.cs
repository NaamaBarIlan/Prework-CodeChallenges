using System;
using System.Linq;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            problem1();

            Console.Clear();

            Problem2();

            Console.Clear();

            Problem3();

            Console.Clear();

            Problem4();
            
        }

        private static void problem1()
        {
            // Request 5 numbers from 1-10 from the user:

            Console.WriteLine("Problem 1: Array Max Result");
            Console.Write("Please enter five numbers between 1-10:");

            string userValues = Console.ReadLine();

            // Declare and initialize an array with the user's input:

            int[] numbersArray = new int[userValues.Length];

            // Loop through the string, convert each char to int and assign to the numbers array. 
            for (int i = 0; i < userValues.Length; i++)
            {
                numbersArray[i] = (int)Char.GetNumericValue(userValues[i]);
            }

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
            Console.ReadLine();
        }

        private static void Problem2()
        {
            Console.WriteLine("Problem 2: Leap Year Calculator");
            Console.WriteLine("Type in a year to find out if it's a leap year: ");
            int inputYear = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Problem 3: Perfect Sequence");
            //Ask the user for the array input:
            Console.WriteLine("Please enter an array of numbers (for example: 1, 3, 5, 7): ");
            
            string inputNumbers = Console.ReadLine();

            // Remove spaces and commas from the string:
            inputNumbers = inputNumbers.Replace(",", "").Replace(" ", "");

            // Convert the input from a string into a char array:
            char[] inputChars = inputNumbers.ToCharArray();

            // Declaring an int array:
            int[] numArray = new int[inputChars.Length];

            // Loop through the inputChar array, convert car to int and insert into numArray:
            for (int i = 0; i < inputChars.Length; i++)
            {
                numArray[i] = (int)Char.GetNumericValue(inputChars[i]);
            }

            //Loop through the array to check if any of the numbers are non-negative:

            bool nonNegative = true;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < 0)
                {
                    nonNegative = false;
                    break;
                }
            }

            //Loop through the array to get the sum of all the numbers:

            int sumArray = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                sumArray += numArray[i];
            }
            //Console.WriteLine($"The sum of all numbers: {sumArray}");

            //Loop through the array to get the product of all the numbers:

            int productArray = 1;

            for (int i = 0; i < numArray.Length; i++)
            {
                productArray *= numArray[i];
            }
            //Console.WriteLine($"The product of all numbers: {productArray}");

            //If statement for a Yes/No return:
            //If all the numbers are non-negative && sum == product return Yes, else return "No"

            string message = "";

            if (nonNegative && sumArray == productArray)
            {
                message = "Yes, this is a perfect sequence!";

            }
            else
            {
                message = "No, this is not a perfect sequence.";
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }

        private static void Problem4()
        {
            Console.WriteLine("Problem 4: Sum of Rows");

            // Ask the user for the length of the array:
            Console.WriteLine("What is the length (number of rows) of your array?");

            // Convert the user input from string to int:
            int rowsNumber = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the width of the array:
            Console.WriteLine("What is the width (number of columns) of your array?");

            // Convert the user input from string to int:
            int columnsNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Declare a 2D array with the user input for rows and columns:
            int[,] myArray = new int[rowsNumber, columnsNumber];

            int rowLength = myArray.GetLength(0);
            int colLength = myArray.GetLength(1);

            // Populate the 2D array with random numbers:

            // Instantiate random number generator:
            var rand = new Random();

            //Defining sumArray, an integer array of all the row sums:
            int[] sumArray = new int[rowLength];

            // Display the 2D matrix:
            Console.WriteLine("The 2D matrix that was generated using random numbers:");

            for (int i = 0; i < rowsNumber; i++)
            {
                int rowSum = 0;

                for (int j = 0; j < columnsNumber; j++)
                {
                    myArray[i, j] = rand.Next(-10, 10);
                    rowSum += myArray[i, j];
                    Console.Write(string.Format("{0} ", myArray[i, j]));
                }
                Console.WriteLine();

                sumArray[i] = rowSum;
            }
            Console.WriteLine();

            // The final output - a sum of each row in the 2D array: 
            Console.WriteLine("The sum of rows in your 2D array is:");
            Console.WriteLine("[{0}]", string.Join(", ", sumArray));

            Console.ReadLine();
        }
    }
}
