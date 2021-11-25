using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePractice
{
    class InsertionSort
    {
        private static int IndexStart = 0;
        private static int IndexEnd = 1;

        private static int Cache;

        private static int[] SortedData;


        private static bool taskComplete = false;

        public static int[] SortData(int[] UnsortedData)
        {
            Console.WriteLine(string.Join(" ", UnsortedData));

            if (IndexEnd >= UnsortedData.Length)
            {
                IndexStart = 0;
                IndexEnd = 1;
                taskComplete = true;
            }

            //Do Linear Sort Step
            while (UnsortedData[IndexStart] > UnsortedData[IndexEnd])
            {

                Cache = UnsortedData[IndexStart];
                UnsortedData[IndexStart] = UnsortedData[IndexEnd];
                UnsortedData[IndexEnd] = Cache;

                IndexStart++;
                IndexEnd++;

                Console.WriteLine(string.Join(" ", UnsortedData));
            }

            IndexStart++;
            IndexEnd++;

            //End Recurstion Statments
            if (taskComplete == false)
            {
                SortData(UnsortedData);
            }
            else
            {
                Console.WriteLine("End of the line baby~");
                return UnsortedData;
            }

            return null;
        }
    }
}
