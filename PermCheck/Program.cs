using System;
using System.Linq;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 4, 1, 3, 2 };
            int[] arr2 = { 4, 1, 3 };

            Console.WriteLine(Solution(arr1));
            Console.WriteLine(Solution(arr2));
        }

        private static int Solution(int[] A)
        {

            var found = new int[A.Length + 1];

            foreach(var val in A)
            {
                try
                {
                    found[val]++;
                }
                catch (IndexOutOfRangeException)
                {
                    return 0;
                }
            }

            foreach (var count in found.Skip(1))
            {
                if (count == 0 || count >= 2) return 0;
            }
                return 1;
        }
    }
}
