using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingComparison
{
    internal class BubbleSort
    {
        public void Sort(int[] arr)
        {
            bool flag = true;
            for (int i = 0; i < arr.Length && flag; i++)
            {
                flag = false;
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap
                        arr[j] ^= arr[j+1];
                        arr[j+1] ^= arr[j];
                        arr[j] ^= arr[j+1];
                        flag = true;
                    }
                }
            }
        }
    }
}
