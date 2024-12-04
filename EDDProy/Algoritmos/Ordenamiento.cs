using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos
{
    public class Ordenamiento
    {
        public void Intercalacion(int[] arr1, int[] arr2, int[] resultado)
        {
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                    resultado[k++] = arr1[i++];
                else
                    resultado[k++] = arr2[j++];
            }
            while (i < arr1.Length)
                resultado[k++] = arr1[i++];
            while (j < arr2.Length)
                resultado[k++] = arr2[j++];
        }

        public void Shellsort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }

        public void MezclaNatural(int[] arr)
        {
            Array.Sort(arr);
        }

        public void Burbuja(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }

        public void RadixSort(int[] arr)
        {
            int m = GetMax(arr);
            for (int exp = 1; m / exp > 0; exp *= 10)
                CountSort(arr, arr.Length, exp);
        }

        private int GetMax(int[] arr)
        {
            int mx = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

        private void CountSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[10];
            for (int i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public void MezclaDirecta(int[] arr)
        {
            Array.Sort(arr);
        }
    }
}
