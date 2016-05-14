using System;


namespace SortingMethods
{
    public class InsertionSort<T> : TrackSorting<T>, ISorter<T> where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (Compare(items[sortedRangeEndIndex], items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }
        }

        private int FindInsertionIndex(T[] items, T valueToInsert)
        {
            for (int index = 0; index < items.Length; index++)
            {
                if (Compare(items[index], valueToInsert) > 0)
                {
                    return index;
                    
                }
            }

            throw new InvalidOperationException("The insertion index was not found");
        }

        private void Insert(T[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            T temp = itemArray[indexInsertingAt];
            
            Assign(itemArray, indexInsertingAt, itemArray[indexInsertingFrom]);

            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                Assign(itemArray, current, itemArray[current - 1]);
            }

            Assign(itemArray, indexInsertingAt + 1, temp);
        }
    }
}
