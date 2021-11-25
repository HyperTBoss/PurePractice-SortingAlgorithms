using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePractice
{
    class LinearSearch
    {
        private static int Ankor = -1;

        private static int Cache;

        private static bool taskComplete = false;

        public static int SearchDataIndex(int[] Data, int valueWanted)
        {
            for (int i = 0; i < Data.Length; i++)
            {
                if (Data[i] == valueWanted)
                {
                    return i;
                }
            }

            //End Recurstion Statments
            Console.WriteLine("End of the line baby~");

            return -1;
        }
    }
}
