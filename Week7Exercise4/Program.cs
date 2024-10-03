using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise3
{
    internal class Program
    {
        static void PrintArray(int[,] num) //method to print the array in a matrix
        {
            int rows = num.GetLength(0); //declares and initalizes row variable
            int cols = num.GetLength(1); //declares and initalizes col variable
            int count = 0;  //declares and initalizes count variable

            foreach (int element in num) //foreach loop to loop through each index and element of the array
            {
                Console.Write(element + " "); //writes the element of the index
                count++; //count adds 1 to itself
                if (count % cols == 0) //if loop to check if the remainder of count and cols is equal to 0
                {
                    Console.WriteLine(); //writes a blank line
                }
            }
        }

        static void PrintSum(int[,] num) //method to print the sum of the array
        {
            int sum = 0; //declares and initializes sum to 0
            foreach (int element in num) //foreach loop to loop through each index and element
            {
                sum += element; //adds element number to the sum
            }
            Console.WriteLine("The sum is: " + sum); //writes the sum
        }

        static int[,] ArrayTransposed(int[,] num) //method to flip the array matrix
        {
            int rows = num.GetLength(0); //declares and initalizes rows variable
            int cols = num.GetLength(1); //declares and initalizes cols variable
            int[,] flipped = new int[cols, rows];  //declares flipped matrix array

            for (int i = 0; i < rows; i++) //for loop to loop through each row
            {
                for (int j = 0; j < cols; j++) //for loop to loop through each colomn
                {
                    flipped[j, i] = num[i, j]; //sets the index and element number in flipped array
                }
            }
            return flipped; //returns flipped array
        }
        static void Main(string[] args) //main method
        {
            int[,] numbers = { { 1, 2, 3, }, { 4, 5, 6, } }; //declares and initializes array matrix

            PrintArray(numbers); //calls PrintArray method with numbers array as input
            PrintSum(numbers); //calls PrintSum method with numbers array as input
            int[,] transposedMatrix = ArrayTransposed(numbers); //declares new matrix array and sets it equal to the method ArrayTransposed with numbers array as input
            PrintArray(transposedMatrix); //calls PrintArray method with transposedMatrix array as input

            Console.Read(); //lets the user read the program
        }
    }
}