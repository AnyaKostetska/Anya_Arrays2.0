using System;

namespace ArrayLibrary
{
    public class Arrays
    {
        public static int GetMinOfArray(int[] array)
        {
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        public static int GetMaxOfArray(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        public static int GetIndexOfMinValueOfArray(int[] array)
        {
            int minValue = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int GetIndexOfMaxValueOfArray(int[] array)
        {
            int maxValue = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int GetSumOfElementsWithOddIndexes(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + array[i];
                }
            }

            return sum;
        }

        //public static int GetReverseOfArray(int[] array)
        //{
        //    int i = array.Length;
        //    for (int j = 1; j < array.Length; j++)
        //    {
        //        int temp = array[j];
        //        array[j] = array[i - j - 1];
        //        array[i - j - 1] = temp;
        //    }
        //    return array[i];
        //}

        public static int GetCountOfOddElements(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
