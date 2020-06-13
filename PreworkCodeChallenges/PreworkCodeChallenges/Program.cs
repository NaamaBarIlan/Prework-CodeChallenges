using System;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            problem1();
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
    }
}
