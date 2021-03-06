﻿using System;

namespace SortingMethods
{
    public class BubbleSort<T>:TrackSorting<T>, ISorter<T> where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < items.Length; i++)
                {
                    if (Compare(items[i - 1], items[i]) > 0)
                    {
                        Swap(items, i - 1, i);
                        swapped = true;
                    }
                }
            } while (swapped != false);
        }
    }
}
