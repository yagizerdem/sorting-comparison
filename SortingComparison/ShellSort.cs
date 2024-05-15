﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingComparison
{
    internal class ShellSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n/2; gap >0; gap /=2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = 0;
                    for ( j = i; j >=gap && arr[j-gap] >temp;j-=gap)
                    {
                        arr[j] = arr[j-gap];
                    }
                    arr[j] = temp;
                }
            }
        }
    }
}
