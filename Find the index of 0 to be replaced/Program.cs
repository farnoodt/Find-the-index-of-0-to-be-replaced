using System;

namespace Find_the_index_of_0_to_be_replaced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 0, 1, 0, 1, 1, 1, 0, 1, 1 };

            Console.WriteLine(findIndexofZero(A).ToString());
        }

        public static int findIndexofZero(int[] arr)
        {
            int MaxIdx = -1;
            int PrvZero = -1;
            int Count = 0;
            int MaxCount = 1;
            int len = arr.Length;
            if (len < 2)
                return len;
            
            for(int i =0; i < len; i++)
            {
                if (arr[i] == 1)
                    Count++;
                else
                {
                    Count = i - PrvZero;
                    PrvZero = i;
                }

                if (Count > MaxCount)
                { 
                    MaxCount = Count;
                    MaxIdx = PrvZero;
                }
            }

            return MaxIdx;
        } 
    }
}
