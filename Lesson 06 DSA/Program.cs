using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_06_DSA
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var arrayToSort = GenerateArray(20000);
            //Console.WriteLine($"Array created - timer={stopwatch.ElapsedMilliseconds}");

            //stopwatch.Restart();
            //var array1 = BubbleSort(arrayToSort);
            //Console.WriteLine($"Bubble sort - timer={stopwatch.ElapsedMilliseconds}");

            //stopwatch.Restart();
            //var array2 = SelectionSort(arrayToSort);
            //Console.WriteLine($"Selection sort - timer={stopwatch.ElapsedMilliseconds}");

            //stopwatch.Restart();
            //var array3 = InsertionSort(arrayToSort);
            //Console.WriteLine($"Insertion sort - timer={stopwatch.ElapsedMilliseconds}");

            //Homework
            StudentsManager.Test();

            Console.ReadKey();
        }

        private static int[] GenerateArray(int size)
        {
            int[] randomArray = new int[size];

            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                randomArray[i] = rnd.Next(1, 10000);
            }

            return randomArray;
        }

        private static int[] BubbleSort(int[] unsortedArray)
        {
            int[] arrayToSort = (int[])unsortedArray.Clone();

            int outer, inner;

            for (outer = arrayToSort.Length - 1; outer > 0; outer--) // counting down
            {
                for (inner = 0; inner < outer; inner++) // bubbling up
                {
                    if (arrayToSort[inner] > arrayToSort[inner + 1]) // if out of order...
                    {
                        // ...then swap
                        int temp = arrayToSort[inner];
                        arrayToSort[inner] = arrayToSort[inner + 1];
                        arrayToSort[inner + 1] = temp;
                    }
                }
            }

            return arrayToSort;
        }

        public static int[] SelectionSort(int[] unsortedArray)
        {
            int[] arrayToSort = (int[])unsortedArray.Clone();

            int outer, inner, min;
            for (outer = 0; outer < arrayToSort.Length - 1; outer++)
            {
                // outer counts down
                min = outer;
                for (inner = outer + 1; inner < arrayToSort.Length; inner++)
                {
                    if (arrayToSort[inner] < arrayToSort[min])
                    {
                        min = inner;
                    }
                    // Invariant: for all i, if outer <= i <= inner, then a[min] <= a[i]
                }
                // a[min] is least among a[outer]..a[a.length - 1]
                int temp = arrayToSort[outer];
                arrayToSort[outer] = arrayToSort[min];
                arrayToSort[min] = temp;
                // Invariant: for all i <= outer, if i < j then a[i] <= a[j]
            }

            return arrayToSort;
        }

        private static int[] InsertionSort(int[] unsortedArray)
        {
            int[] arrayToSort = (int[])unsortedArray.Clone();

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                /*storing current element whose left side is checked for its  correct position .*/
                int temp = arrayToSort[i];
                int j = i;

                /* check whether the adjacent element in left side is greater or less than the current element. */
                while (j > 0 && temp < arrayToSort[j - 1])
                {
                    // moving the left side element to one position forward.
                    arrayToSort[j] = arrayToSort[j - 1];
                    j = j - 1;
                }
                // moving current element to its  correct position.
                arrayToSort[j] = temp;
            }

            return arrayToSort;
        }
    }
}
