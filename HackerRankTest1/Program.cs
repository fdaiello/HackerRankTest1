using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTest1
{
    public class Result
    {

        /*
         * Complete the 'fizzBuzz' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void fizzBuzz(int n)
        {

            for ( int x = 1; x<=n; x++)
            {
                if (x / 3 == (float)x / 3 && x / 5 == (float)x / 5)
                    Console.WriteLine("FizzBuzz");

                else if (x / 3 == (float)x / 3 && x / 5 != (float)x / 5)
                    Console.WriteLine("Fizz");

                else if (x / 3 != (float)x / 3 && x / 5 == (float)x / 5)
                    Console.WriteLine("Buzz");

                else
                    Console.WriteLine(x);

            }
        }

        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            return arr[arr.Count / 2];
        }

        public static int flippingMatrix(List<List<int>> matrix)
        {
            // Sum Counter
            int sum = 0;

            // Loop half rows
            for ( int row=0; row < matrix.Count/2; row++)
            {
                // Loop half columns
                for ( int col=0; col < matrix.Count/2; col++)
                {
                    // Calc counterparts
                    int rowS = matrix.Count - row - 1;
                    int colS = matrix.Count - col - 1;

                    // Build array with 4 elements of each quadrant, on the same possible exchaged position
                    int[] simetricElements = new int[] { matrix[row][col], matrix[rowS][col], matrix[rowS][colS], matrix[row][colS] };

                    // Add to the sum the greater elemet
                    sum += simetricElements.Max();
                }
            }

            // Return Sum
            return sum;
        }

        /*
         * Return the number of pairs ( equal numbers ) in array
         */
        public static int sockMerchant(int n, List<int> ar)
        {
            // pair counters
            int c = 0;

            // last unPaired 
            int? lastUnpaired = null;

            // Sor array
            ar.Sort();

            // Loop sorted array
            for (int x = 0; x<ar.Count; x++)
            {
                if (ar[x] == lastUnpaired)
                {
                    c++;
                    lastUnpaired = null;
                }
                else
                {
                    lastUnpaired = ar[x];
                }
            }

            // return pair caunter
            return c;
        }

        public static void findZigZagSequence(int[] a, int n)
        {
            Array.Sort(a);

            int mid = n  / 2;
            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st = st + 1;
                ed = ed - 1;
            }


            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.Write(" ");
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Result.findZigZagSequence(a, a.Length);
        }
    }
}
