# Test Scores Program

This C# program demonstrates various array operations and search algorithms using a test scores scenario. It includes functionality for shuffling arrays, sorting using selection sort, and performing linear and binary searches.

## Features

1. **Array Shuffling**: Randomly reorders the elements in an array.
2. **Selection Sort**: Sorts the array in ascending order.
3. **Linear Search**: Searches for a value in an unsorted array.
4. **Binary Search**: Searches for a value in a sorted array.

## How to Use

The program contains three main problem sets:

1. **Shuffle Array Problem**
   - Demonstrates shuffling of an array of test scores.

2. **Selection Sort Problem**
   - Shows how to sort an array of test scores using the selection sort algorithm.

3. **Linear and Binary Search Problem**
   - Compares linear and binary search methods on an array of test scores.

To run a specific problem, uncomment the corresponding method call in the `Main` method.

## Key Functions

- `GetScores`: Prompts user to input test scores.
- `DisplayScores`: Prints the array of scores.
- `ShuffleArray`: Randomly reorders array elements.
- `SelectionSort`: Sorts the array in ascending order.
- `IndexOfLinear`: Performs a linear search on the array.
- `IndexOfBinary`: Performs a binary search on the sorted array.
- `GetInt`: Utility function for getting valid integer input from the user.

## Implementation Details

- Uses a constant `SIZE` to define the maximum number of scores.
- Implements input validation to ensure scores are within a valid range (0-100).
- The shuffle algorithm uses the Fisher-Yates shuffle method.
- The binary search function assumes the array is sorted in ascending order.

