using System;
using System.Linq;

namespace PurePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntArray = Enumerable.Range(1, 10).ToArray();
            var rng = new Random();

            Console.WriteLine(BinarySearch.SearchDataIndex(IntArray, 4) + " This is LinearSearch");
            Console.WriteLine(" ");
            Console.Read();

            //Mutate For Sort
            rng.Shuffle(IntArray);

            Console.WriteLine(string.Join("-", InsertionSort.SortData(IntArray)) + " This is InsertionSort");
            Console.WriteLine(" ");
            Console.Read();
        }


    }
    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
