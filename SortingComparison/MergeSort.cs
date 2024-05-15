using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SortingComparison
{
    internal class MergeSort
    {
        public void Sort(int[] arr)
        {
            if(arr.Length <= 1)
            {
                return;
            }
            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];


            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for(int j = 0; j < arr.Length - mid; j++)
            {
                right[j] = arr[mid + j];
            }
            Sort(left);
            Sort(right);
            Merge(arr, left, right);

        }
        public void Merge(int[] arr , int[] left , int[] right)
        {
            int i = 0, k = 0, j = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }
            while(i < left.Length)
            {
                arr[k++] = left[i++];
            }
            while(j < right.Length)
            {
                arr[k++] = right[j++];
            }
        }
    }
}
