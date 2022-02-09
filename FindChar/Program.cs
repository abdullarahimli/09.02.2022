using System;

namespace FindChar
{
    class Program
    {
        static void Main(string[] args)
        {
			// Stringlerden ibaret array-i və char qəbul edən metod yazın.
			// Arrayin hansi indexin-də bu qəbul edilən char varsa, o string-ləri ekranda yazdirin.

			char x = char.Parse(Console.ReadLine());
            string y = Console.ReadLine();
            string[] text = y.Split(" ");


			FindChar(text, x);
        }


		public static void FindChar(string[] a, char b)
		{

			for (int i = 0; i < a.Length; i++)
			{
				string c = a[i];

				for (int j = 0; j < c.Length; j++)
				{
					if (c[j] == b)
					{
						Console.WriteLine(c);
						break;
					}

				}

			}

		}
	}
}
