using System;

namespace TestScoresStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 6 Problem 1: Shuffle Array
             //ShuffleArrayProblem();

            // Lab 6 Problem 2: Selection Sort
             //SelectionSortProblem();

            // Lab 6 Problem 3: Linear and Binary Search
            LinearAndBinarySearchProblem();
        }

        static void ShuffleArrayProblem()
        {
            const int SIZE = 5;
            int[] scores = new int[SIZE];
            int numScores = 0;

            GetScores(scores, out numScores);
            Console.WriteLine("Original array:");
            DisplayScores(scores, numScores);

            ShuffleArray(scores, numScores);
            Console.WriteLine("After shuffling:");
            DisplayScores(scores, numScores);
        }

        static void SelectionSortProblem()
        {
            const int SIZE = 5;
            int[] scores = new int[SIZE];
            int numScores = 0;

            GetScores(scores, out numScores);
            Console.WriteLine("Original array:");
            DisplayScores(scores, numScores);

            SelectionSort(scores, numScores);
            Console.WriteLine("After sorting:");
            DisplayScores(scores, numScores);
        }

        static void LinearAndBinarySearchProblem()
        {
            const int SIZE = 5;
            int[] scores = new int[SIZE];
            int numScores = 0;

            GetScores(scores, out numScores);
            Console.WriteLine("Original array:");
            DisplayScores(scores, numScores);

            int searchValue = GetInt("search value", 0, 100);

            int linearResult = IndexOfLinear(scores, numScores, searchValue);
            Console.WriteLine($"Linear Search Result: {linearResult}");

            SelectionSort(scores, numScores);
            int binaryResult = IndexOfBinary(scores, numScores, searchValue);
            Console.WriteLine($"Binary Search Result: {binaryResult}");
        }

        static void GetScores(int[] scores, out int numScores)
        {
            numScores = 0;
            int score = GetInt("score", -1, 100);
            while (score != -1 && numScores < scores.Length)
            {
                scores[numScores] = score;
                numScores++;
                if (numScores != scores.Length)
                    score = GetInt("score", -1, 100);
            }
        }

        static void DisplayScores(int[] scores, int numScores)
        {
            for (int i = 0; i < numScores; i++)
                Console.WriteLine("Score {0} is: {1}", i + 1, scores[i]);
        }

        static void ShuffleArray(int[] array, int length)
        {
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                int rndIndex = rand.Next(i, length);
                int temp = array[i];
                array[i] = array[rndIndex];
                array[rndIndex] = temp;
            }
        }

        static void SelectionSort(int[] array, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                int indexOfMin = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[indexOfMin])
                    {
                        indexOfMin = j;
                    }
                }
                if (indexOfMin != i)
                {
                    int temp = array[i];
                    array[i] = array[indexOfMin];
                    array[indexOfMin] = temp;
                }
            }
        }

        static int IndexOfLinear(int[] array, int length, int target)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;
        }

        static int IndexOfBinary(int[] array, int length, int target)
        {
            int lowerBound = 0;
            int upperBound = length - 1;
            int index = -1;
            while (lowerBound <= upperBound)
            {
                int midPoint = lowerBound + (upperBound - lowerBound) / 2;
                if (array[midPoint] < target)
                    lowerBound = midPoint + 1;
                else if (array[midPoint] > target)
                    upperBound = midPoint - 1;
                else
                {
                    index = midPoint;
                    break;
                }
            }
            return index;
        }

        static int GetInt(string label, int min, int max)
        {
            bool isInt = false;
            int number = min - 1;
            do
            {
                Console.Write($"Please enter a whole number between {min} and {max} for {label}: ");
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
            } while (!(isInt && number >= min && number <= max));

            return number;
        }
    }
}