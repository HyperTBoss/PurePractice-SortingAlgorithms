using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePractice
{
    class BinarySearch
    {
        private static int IndexStart = 0;
        private static int IndexEnd = 1;
        private static int Ankor = 0;

        private static int Cache;

        private static bool taskComplete = false;

        public static int SearchDataIndex(int[] Data, int valueWanted)
        {
            IndexEnd = Data.Length - 1;

            for (int i = 0; i < Data.Length; i++)
            {
                Ankor = ReturnMiddlePoint();

                if (Data[Ankor] == valueWanted)
                {
                    return Ankor;
                }

                if (Data[Ankor] > valueWanted)
                {
                    IndexEnd /= 2;
                }
                else if (Data[Ankor] < valueWanted)
                {
                    IndexStart += IndexEnd / 2;
                }
            }

            return -1;
        }

        private static int ReturnMiddlePoint()
        {
            float Result = (IndexStart + IndexEnd) / 2;

            return (int)Math.Round(Result, MidpointRounding.AwayFromZero);
        }
    }
}
