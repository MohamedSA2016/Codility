using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            StringBuilder s = new StringBuilder(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine());

            string result = caesarCipher(s, k);

            Console.WriteLine(result);
        }

        private static string caesarCipher(StringBuilder s, int k)
        {
            k %= 26;

            for (int i = 0; i < s.Length; i++)
            {
                int a = Convert.ToInt32(s[i]);

                if ((a >= 65 && a <= 90))
                {
                    if (a + k > 90)
                        s[i] = (char)(k - Math.Abs(a - 90) + 64);
                    else
                        s[i] = (char)(a + k);
                }
                else if ((a >= 97 && a <= 122))
                {
                    if (a + k > 122)
                        s[i] = (char)(k - Math.Abs(a - 122) + 96);
                    else
                        s[i] = (char)(a + k);
                }
            }
            return s.ToString();
        }
    }
}
