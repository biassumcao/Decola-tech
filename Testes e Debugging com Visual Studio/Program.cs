using System;
namespace Ordenacao
{
    public class Ordenacao
    {
        public int[] bubbleSort(int[] arr)
        {
            int num = arr.Length;

            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }

            }

            return arr;

        }
    }
}