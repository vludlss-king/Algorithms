namespace Algorithms.BinarySearch
{
    internal static class ListExtensions
    {
        public static int? CustomBinarySearch<T>(this IList<T> items, T item)
            where T : IComparable<T>
        {
            var low = 0;
            var high = items.Count - 1;

            while(low <= high)
            {
                var middle = (low + high) / 2;
                var middleItem = items[middle];
                if (middleItem.CompareTo(item) == 0)
                    return middle;
                if (middleItem.CompareTo(item) == 1)
                    high = middle - 1;
                else
                    low = middle + 1;
            }
            return null;
        }
    }
}
