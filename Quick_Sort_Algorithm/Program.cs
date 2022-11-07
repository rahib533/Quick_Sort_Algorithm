using System;

namespace Quick_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 25, 10, 5, 6, 30, 40, 2, 1, 18, 7 };
            //int[] arr = { 25, 10, 1, 6, 30, 40, 5, 4, 18, 7 };
            //int[] arr = {6, 10, 2, 3, 17, 9 };
            //int[] arr = {6, 4, 10, 8, 1, 7, 2, 3, 17, 9 };
            int[] arr = { 6, 4, 10, 8, 1, 7, 2, 3, 17, 9, 9, 65, 22, 54, 4545, 223, 56, 78 };
            QuickSort(arr, arr.Length - 1, 0, arr.Length);

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        static void QuickSort(int[] arr, int pivotIndex, int j, int currentLenght)
        {
            if (currentLenght <= 1)
                return;

            int fixedBeginIndex = j;
            int pivot = arr[pivotIndex];
            int i = j - 1;

            while (j <= pivotIndex)
            {
                if (pivot > arr[j])
                {
                    i++;
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
                if (j == pivotIndex)
                {
                    i++;
                    arr[pivotIndex] = arr[i];
                    arr[i] = pivot;
                }
                j++;
            }

            if (i != fixedBeginIndex && i > 0)
            {
                QuickSort(arr, i - 1, fixedBeginIndex, i);
            }
            if (i < pivotIndex)
            {
                QuickSort(arr, pivotIndex, i + 1, pivotIndex - i);
            }
        }
    }
}
