using System;
using System.Linq;

namespace PurePractice
{
    class Program
    {
        public static int IncrementingValue = 0;
        public static bool EndRecur = false;

        static void Main(string[] args)
        {
            Console.WriteLine("aaa");

            

            Console.Read();
        }

        static void StartSorts(int SortType, int[,] StorgeUnites_2DShelf)
        {
            RecursiveFunction(StorgeUnites_2DShelf);
        }
        static void RecursiveFunction(int[,]  StorgeUnites_2DShelfCache)
        {



            if (EndRecur == true)
            {
                Console.WriteLine("End of the line baby~");
                Console.ReadKey();
                return;
            }
            else
            {
                RecursiveFunction();
            }
        }

        static int MergeSort()
        {
             
        }

        static int InsertionSort()
        {

        }
        static int QuickSort()
        {

        }

        static int BubbleSort()
        {

        }
    }
}
