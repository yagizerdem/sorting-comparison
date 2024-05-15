using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingComparison
{
    internal class SelectionSort
    {
        public void Sort(int[] arr) {
            int temp, smallest;
            for (int i = 0; i < arr.Length -1; i++)
            {
                smallest = i;
                for (int j = i+ 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }  
    }
}
