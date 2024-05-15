using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace SortingComparison
{
    internal class HeapSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2; i >= 0; i--)
            {
                heapify(arr, n, i);
            }
            for (int i = n-1; i> 0; i--)
            {
                int swap = arr[0];
                arr[0] = arr[i];
                arr[i] = swap;
                heapify(arr, i, 0);
            }
        }
        public void heapify(int[]arr , int n , int i)
        {
            int largest = i;
            int r = i * 2 + 2;
            int l = i * 2 + 1;
            if(l < n && arr[l] > arr[largest])
            {
                largest = l;
            }
            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }
            if(largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }
    }
}
