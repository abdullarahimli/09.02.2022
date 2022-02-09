using System;

namespace FindChar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ədədlərdən ibarət array qəbul edən method yazın.
            // Array sort metoduna uyğun CustomSort(int[] arr) metodunu yazın.

            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            int c = int.Parse(Console.ReadLine());

            int[] arr = { a, b, c };

            CustomSort(arr);
        }
        public static void CustomSort(int[] a)
        {
            Console.Write("DAxil etdiyiniz forma");

            foreach (int value in a)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("      ");

            Console.Write("Donusturulmus forma");

            Array.Sort(a);

            foreach (int value in a)
            {
                Console.Write(value + " ");
            }
        }
    }
}
