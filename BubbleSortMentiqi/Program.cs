using System;

namespace BubbleSortMentiqi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ci ededi daxil edin");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2 ci ededi daxil edin");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("3 cu ededi daxil edin");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("4 ci ededi daxil edin");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("5 ci ededi daxil edin");
            int e = int.Parse(Console.ReadLine());

            int[] arr = { a, b, c, d, e };

            CustomSort(arr);

            Console.WriteLine("Proses ugurla basa catdi");

            printArray(arr);
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void CustomSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)

                for (int j = 0; j < n - i - 1; j++)

                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }


    }
}
