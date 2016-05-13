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

        }
    }
}
