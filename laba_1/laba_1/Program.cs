using System;

namespace laba_1
{
    public class HW1
    {   private static int min_element(int[] array, int value)
        {
            int min = 9999;
            int index = 0;
            for (int i = 0; i < value; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

        private static int max_element(int[] array, int value)
        {
            int max = 0;
            for (int i = 0; i < value; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static long QueueTime(int[] array, int size, int value)
        {
            if (value == 1)
            {
                int sum = 0;
                for (int i = 0; i < size; i++)
                {
                    sum = sum + array[i];
                }
                return sum;
            }
            else
            {
                int[] kassa = new int[value];
                int min = 0, max = 0;
                for (int i = 0; i < value; i++)
                {
                    kassa[i] = 0;
                }
                for (int i = 0; i < size; i++)
                {
                    min = min_element(kassa, value);
                    kassa[min] = kassa[min] + array[i];
                }
                
                max = max_element(kassa, value);
                return max;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 4 };
            int n = 2;

            long output = HW1.QueueTime(array, 3,  n);
            Console.WriteLine(output);
        }
    }
}
