using System;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Solution(new int[] { 10, 1, 32, 4, 300, 5 });
            Console.WriteLine(r);
        }

        private static int Solution(int[] A)
        {
			int result = 0;
			int min = int.MaxValue;
			int p = 1;
			int first = 0;
			int second = 0;

			while (p < A.Length)
			{
				Console.WriteLine("p: {0}", p);
				for (int i = 0; i < A.Length; i++)
				{
					Console.WriteLine("i: {0}", i);
					Console.WriteLine("before first: {0}, second:{0}", first, second);
					Console.WriteLine("if(i < p)");
					if (i < p)
					{
						first = first + A[i];
						Console.WriteLine("first += A[i];");
						second = 2;
					}
					else
					{
						//second = second + A[i];
						Console.WriteLine("second += A[i];");
					}
					second = 0;
					Console.WriteLine("after first: {0}, second:{0}", first, 0);
				}
				result = Math.Abs(first - second);
				Console.WriteLine("result: {0}", result);
				if (result < min)
					min = result;

				p++;
			}

			return min;
		}
    }
}
