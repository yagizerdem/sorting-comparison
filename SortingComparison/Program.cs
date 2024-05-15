using System.Diagnostics;

namespace SortingComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BubbleSort bubbleSort = new BubbleSort();
            InsertionSort insertionSort = new InsertionSort();
            SelectionSort selectionSort = new SelectionSort();
            MergeSort mergeSort = new MergeSort();
            ShellSort shellSort = new ShellSort();
            HeapSort heapSort = new HeapSort();
            Stopwatch stopwatch = new Stopwatch();


            int[] randomData = generateRandomData();


            Console.WriteLine("Bubble Sort Started");
            Console.WriteLine("----------------------");
            stopwatch.Start();
            bubbleSort.Sort(randomData);
            stopwatch.Stop();
            Console.WriteLine($"buble sort time -> {stopwatch.Elapsed}");
            Console.WriteLine("----------------------");

            stopwatch.Reset();

            randomData = generateRandomData();
            Console.WriteLine("Insertion Sort Started");
            Console.WriteLine("----------------------");
            stopwatch.Start();
            insertionSort.Sort(randomData);
            stopwatch.Stop();
            Console.WriteLine($"insertion sort time -> {stopwatch.Elapsed}");
            Console.WriteLine("----------------------");

            stopwatch.Reset();

            randomData = generateRandomData();
            Console.WriteLine("Selection Sort Started");
            Console.WriteLine("----------------------");
            stopwatch.Start();
            selectionSort.Sort(randomData);
            stopwatch.Stop();
            Console.WriteLine($"selection sort time -> {stopwatch.Elapsed}");
            Console.WriteLine("----------------------");

            stopwatch.Reset();
            randomData = generateRandomData();
            Console.WriteLine("Merge Sort Started");
            Console.WriteLine("----------------------");
            stopwatch.Start();
            mergeSort.Sort(randomData);
            stopwatch.Stop();
            Console.WriteLine($"merge sort time -> {stopwatch.Elapsed}");
            Console.WriteLine("----------------------");

            stopwatch.Reset();

            randomData = generateRandomData();
            Console.WriteLine("Shell Sort Started");
            Console.WriteLine("----------------------");
            stopwatch.Start();
            shellSort.Sort(randomData);
            stopwatch.Stop();
            Console.WriteLine($"shell sort time -> {stopwatch.Elapsed}");
            Console.WriteLine("----------------------");

            stopwatch.Reset();

            randomData = generateRandomData();
            Console.WriteLine("Heap Sort Started");
            Console.WriteLine("----------------------");
            stopwatch.Start();
            heapSort.Sort(randomData);
            stopwatch.Stop();
            Console.WriteLine($"heap sort time -> {stopwatch.Elapsed}");
            Console.WriteLine("----------------------");


        }
        static int[] generateRandomData()
        {
            int[] data = new int[100000];
            Random rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next();
            }
            return data;
        }
    }
}
