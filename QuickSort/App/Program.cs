using Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Launch();
        }

        public static void Launch()
        {
            Console.WriteLine("Input length of array");
            int length = GetInputArrayLength();

            Console.WriteLine("Input array");
            int[] numbers = GetInputArray(length);

            var service = new SortingService();

            while (true)
            {
                ShowMenu();
                int item = GetMenuItem();
                SortArrayOrHandleException(service, numbers, item);
                PrintArray(numbers);
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Choose menu item:");
            Console.WriteLine("1. QuickSort");
            Console.WriteLine("2. MergeSort");
        }

        public static int GetMenuItem()
        {
            int item = 0;
            while (item != SortingFactory.TYPE_MERGESORT && item != SortingFactory.TYPE_QUICKSORT)
                item = GetInputNumber();
            return item;
        }

        private static int GetInputNumber()
        {
            int number;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out number))
                input = Console.ReadLine();
            return number;
        }

        public static int GetInputArrayLength()
        {
            int length = -1;
            while (length < 0)
                length = GetInputNumber();
            return length;
        }

        public static int[] GetInputArray(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = GetInputNumber();
            }
            return numbers;
        }

        public static void PrintArray(int[] numbers)
        {
            Console.WriteLine("Array: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void SortArrayOrHandleException(SortingService service, int[] numbers, int item)
        {
            try
            {
                service.Sort(numbers, item);
            }
            catch (NullSortObjetException e)
            {
                Console.WriteLine("Catched exception" + e.Message);
            }
        }

    }
}
