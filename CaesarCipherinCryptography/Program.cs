using System;
using System.Text;

namespace CaesarCipherinCryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "ATTACKATONCE";
            int s = 4;
            Console.WriteLine("Text : " + text);
            Console.WriteLine("Shift : " + s);
            Console.WriteLine("Cipher: " + encrypt(text, s));
        }

        private static StringBuilder encrypt(string text, int s)
        {
            StringBuilder result = new StringBuilder();
            for(int i =0; i <text.Length;i++)
            {
                if(char.IsUpper(text[i]))
                {
                    char ch = (char)(((int)text[i] +
                                s - 65) % 26 + 65);
                    result.Append(ch);
                }
                else
                {
                    char ch = (char)(((int)text[i] +
                               s - 97) % 26 + 97);
                    result.Append(ch);
                }

            }
            return result;

        }
    }
}
