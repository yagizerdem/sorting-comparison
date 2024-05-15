using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingComparison
{
    internal class InsertionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 1; i <arr.Length; i++)
            {
                int j = i;
                while(j > 0  && arr[j] < arr[j - 1])
                {
                    arr[j] ^= arr[j - 1];
                    arr[j-1] ^= arr[j];
                    arr[j] ^= arr[j - 1];
                    j--;
                }
            }
        }
    }
}
