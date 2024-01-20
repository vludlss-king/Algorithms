using Algorithms.BinarySearch;

namespace Algorithms.BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = list.CustomBinarySearch(8);

            Console.WriteLine($"Позиция элемента в списке: {result?.ToString() ?? "не найдено"}");
            Console.ReadKey();
        }

        
    }
}