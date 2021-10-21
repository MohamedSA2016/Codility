using System;

namespace UtlilZationCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int intastances = (2);
            int[] avarageUtil = { 25,23,1,2,3,4,5,6,7,8,9,10,76,80};
            Console.WriteLine(finalInstance(intastances, avarageUtil));
        }

        private static int finalInstance(int intastances, int[] avarageUtil)
        {
            for(int i =0; i<avarageUtil.Length;i++)
            {
                if(avarageUtil[i] <25 && intastances >1)
                {
                    intastances = (int)(Math.Ceiling(intastances / 2.0));
                    i += 10;

                }
                if( i<avarageUtil.Length&& avarageUtil[i]>60 && intastances<2000000)
                {
                    intastances *= 2;
                    i += 10;

                }
            }    

            return intastances;
        }
    }
}
