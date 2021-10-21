using System;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var A1 = 6;
            var B1 = 11;
            var K1 = 2;

            var A2 = 1;
            var B2 = 1;
            var K2 = 11;

            var A3 = 0;
            var B3 = 2000000000;
            var K3 = 1;

            Console.WriteLine(Solution(A1, B1, K2));

            Console.WriteLine(Solution(A2, B2, K2));
            Console.WriteLine(Solution(A3, B3, K3));
        }

        public static int Solution(int A, int B, int K)
        {
            for(var i = A; i <B;i++)
            {
                if(i% K == 0)
                {
                    var rest = B - 1;

                    return (rest / K) + i;
                }
            }
            return 0;
        } 
    }
}
