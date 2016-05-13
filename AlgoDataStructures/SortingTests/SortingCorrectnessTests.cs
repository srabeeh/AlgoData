using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingMethods;

namespace SortingTests
{
    [TestClass]
    public class SortingCorrectnessTests
    {
        private readonly ISorter<int>[] SortingTypes = new ISorter<int>[]
            {
                new BubbleSort<int>(),
                new QuickSort<int>(),
            };

       [TestMethod]
        public void PreSorted(ISorter<int> sorter)
        {
            int[] presorted = new[] { int.MinValue, 0, 1, 2, 3, 4, 5, 6, 7, int.MaxValue };
            sorter.Sort(presorted);

            AssertArrayIsSorted(presorted);
        }

        [TestMethod]
        public void AllReversed(ISorter<int> sorter)
        {
            int[] reversed = new[] { int.MaxValue, 7, 6, 5, 4, 3, 2, 1, 0, int.MinValue };
            sorter.Sort(reversed);

            AssertArrayIsSorted(reversed);
        }

        [TestMethod]
        public void SingleOutOfOrder(ISorter<int> sorter)
        {
            int[] values = new[] { 1, 0, 2, 3, 4 };
            sorter.Sort(values);

            AssertArrayIsSorted(values);
        }

        [TestMethod]
        public void MultipleOutOfOrder(ISorter<int> sorter)
        {
            int[] values = new[] { 4, 3, 1, 2 };
            sorter.Sort(values);

            AssertArrayIsSorted(values);
        }

        [TestMethod]
        public void RandomValuesSort(ISorter<int> sorter)
        {
            int[] items = new int[1000];
            Random rng = new Random();

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = rng.Next();
            }

            sorter.Sort(items);
            AssertArrayIsSorted(items);
        }

        [TestMethod]
        public void EmptyDoesNotCompareOrSwap(ISorter<int> sorter)
        {
            int[] empty = new int[] { };
            sorter.Sort(empty);

            // this should not have thrown
        }


        private void AssertArrayIsSorted(int[] values)
        {
            int previous = int.MinValue;

            foreach (int current in values)
            {
                Assert.IsTrue(previous <= current, "The current value is greater than the previous value (not sorted)");
                previous = current;
            }
        }
    }
}
