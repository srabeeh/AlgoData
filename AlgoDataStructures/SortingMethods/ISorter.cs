using System;

namespace SortingMethods
{
    public interface ISorter<T> : IPerformanceTracker where T : IComparable<T>
    {
        void Sort(T[] items);
    }
}
