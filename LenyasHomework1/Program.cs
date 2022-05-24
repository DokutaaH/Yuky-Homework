using System;

namespace LenyasHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1

            int[] myArray = new int[]
            {
                9, 27, 19, 100, 24, 16, 78, 65, 91, 10, 11
            };

            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            int avg = sum / myArray.Length;

            Console.WriteLine(avg);

            int aboveAvg = 0;

            for (int j = 0; j < myArray.Length; j++)
            {
                if (myArray[j] > avg)
                {
                    aboveAvg += 1;
                }
            }

            Console.WriteLine("The number of digits greater than array average is: " + aboveAvg);
            Console.WriteLine("================================================================");
            Console.WriteLine();

            // Задача 2

            Random random = new Random();

            int[] testArray2 = new int[15];
            int numberOfNegatives = 0;
            int numberOfZeroes = 0;
            int productOfPositives = 1;

            for (int i = 0; i < testArray2.Length; i++)
            {
                testArray2[i] = random.Next(-15, 15);

                if (testArray2[i] < 0)
                {
                    numberOfNegatives += 1;
                }

                if (testArray2[i] == 0)
                {
                    numberOfZeroes += 1;
                }

                if (testArray2[i] > 0)
                {
                    productOfPositives *= testArray2[i];
                }
            }

            for (int k = 0; k < testArray2.Length; k++)
            {
                Console.Write(testArray2[k] + "; ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of items below zero: " + numberOfNegatives);
            Console.WriteLine("Product of items above zero: " + productOfPositives);
            Console.WriteLine("Number of zeroes: " + numberOfZeroes);
            Console.WriteLine("================================================================");
            Console.WriteLine();

            // Задача 3

            int[] testArray3 = new int[20];
            int numberOfEvens = 0;
            int numberOfOdds = 0;
            
            for (int i = 0; i < testArray3.Length; i++)
            {
                testArray3[i] = random.Next(0, 101);
                if (testArray3[i] % 2 == 0)
                {
                    numberOfEvens += 1;
                }
                else
                {
                    numberOfOdds += 1;
                }
            }

            for (int k = 0; k < testArray3.Length; k++)
            {
                Console.Write(testArray3[k] + "; ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of evens: " + numberOfEvens);
            Console.WriteLine("Number of odds: " + numberOfOdds);

            if (numberOfEvens > numberOfOdds)
            {
                Console.WriteLine("There are more evens");
            }
            else if (numberOfEvens == numberOfOdds)
            {
                Console.WriteLine("There is equal number of evens and odds");
            }
            else
            {
                Console.WriteLine("There are more odds");
            }

            Console.WriteLine("================================================================");
            Console.WriteLine();

            // Задача 4

            float[] testArray4 = new float[]
            {
                12, 42, -24, 16.45f, 65.66666666f, 12.376f, 1920.41f, 12, 42, -24, 16.45f, 65.66666666f, 12.376f, 1920.41f, 195864
            };
            int numOfItems = 0;

            for (int i = 1; i < testArray4.Length; i++)
            {
                if (testArray4[i] > testArray4[0])
                {
                    numOfItems += 1;
                }
            }

            for (int k = 0; k < testArray4.Length; k++)
            {
                Console.Write(testArray4[k] + "; ");
            }
            Console.WriteLine();
            Console.WriteLine($"The number of items bigger than {testArray4[0]} is {numOfItems}");
        }
    }
}
