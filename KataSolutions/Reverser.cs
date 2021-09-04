using System;

namespace KataSolutions
{
    public class Reverser
    {
        public static void Reverse(int[] arr)
        {
            int[] tempArray = new int[arr.Length];
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tempo = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tempo;

            }
        }

        public static int[] GetReverse(int[] original)
        {
            int[] tempArray = new int[original.Length];
            Array.Copy(original, tempArray, original.Length);
            for (int i = 0; i < original.Length / 2; i++)
            {
                int tempo = tempArray[i];
                tempArray[i] = tempArray[tempArray.Length - 1 - i];
                tempArray[tempArray.Length - 1 - i] = tempo;

            }

            return tempArray;
        }
    }
}
