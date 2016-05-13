using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort<int> sort = new BubbleSort<int>();

            int[] nums = new[] {15, 5, 4,1,8,3,9,2,7};

            sort.Sort(nums);

            Console.WriteLine("Bubble Sorted numbers");

            foreach (var number in nums)
            {
                     Console.WriteLine(number);
            }

            InsertionSort<int> insert = new InsertionSort<int>();

            int[] insertSortNums = new[] { 215,55, 5, 10, 4, 6, 1, 8, 3, 9, 2, 7 };

            insert.Sort(insertSortNums);

            Console.WriteLine("Insertion Sort Numbers");

            foreach (var number in insertSortNums)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
