using System;

namespace SubarraySumDivisiblebyK
{
    class Program
    {
        static int k;

        static void Main(string[] args)
        {
            k = 5;
            int maxStart;
            int maxEnd;
            int sum;

            int[] a = new int[] { };
            f(a, 0, a.Length, out maxStart, out maxEnd, out sum);
            Console.WriteLine("{0},{1},{2}", maxStart, maxEnd, sum);

            a = new int[] { 1 };
            f(a, 0, a.Length, out maxStart, out maxEnd, out sum);
            Console.WriteLine("{0},{1},{2}", maxStart, maxEnd, sum);

            a = new int[] { 2, 1 };
            f(a, 0, a.Length, out maxStart, out maxEnd, out sum);
            Console.WriteLine("{0},{1},{2}", maxStart, maxEnd, sum);

            a = new int[] { 2, 3 };
            f(a, 0, a.Length, out maxStart, out maxEnd, out sum);
            Console.WriteLine("{0},{1},{2}", maxStart, maxEnd, sum);

            a = new int[] { 3, 2, 3, 2 };
            f(a, 0, a.Length, out maxStart, out maxEnd, out sum);
            Console.WriteLine("{0},{1},{2}", maxStart, maxEnd, sum);

            a = new int[] { -5, 10, 15, -5 };
            f(a, 0, a.Length, out maxStart, out maxEnd, out sum);
            Console.WriteLine("{0},{1},{2}", maxStart, maxEnd, sum);

            a = new int[] { 1, 2, 2, 1, 1, 4, 5, 3 };
            f(a, 0, a.Length, out maxStart, out maxEnd, out sum);
            Console.WriteLine("{0},{1},{2}", maxStart, maxEnd, sum);

            a = new int[] { -1, -2, -3, -4, -5 };
            f(a, 0, a.Length, out maxStart, out maxEnd, out sum);
            Console.WriteLine("{0},{1},{2}", maxStart, maxEnd, sum);
        }

        static void f(int[] a, int start, int end, out int maxStart, out int maxEnd, out int sum)
        {
            if (end - start < 0)
            {
                throw new ArgumentException();
            }
            else if (end - start == 0)
            {
                maxStart = start;
                maxEnd = end;
                sum = 0;
            }
            else if (end - start == 1)
            {
                if (a[start] % k == 0)
                {
                    maxStart = start;
                    maxEnd = end;
                    sum = a[start];
                }
                else
                {
                    maxStart = -1;
                    maxEnd = -1;
                    sum = 0;
                }
            }
            else
            {
                int leftMaxStart;
                int leftMaxEnd;
                int leftMaxSum;
                int rightMaxStart;
                int rightMaxEnd;
                int rightMaxSum;
                int mid = (start + end) / 2;
                f(a, start, mid, out leftMaxStart, out leftMaxEnd, out leftMaxSum);
                f(a, mid, end, out rightMaxStart, out rightMaxEnd, out rightMaxSum);

                int[] r = new int[k];
                int[] rightEnds = new int[k];   //right end index array
                for (int i = 0; i < k; ++i)
                {
                    rightEnds[i] = -1;
                }
                int midSum = a[mid - 1] + a[mid];
                int midRightSum = midSum;
                int mod = Math.Abs(midRightSum % k);
                if (midRightSum > r[mod] || rightEnds[mod] == -1)
                {
                    r[mod] = midRightSum;
                    rightEnds[mod] = mid + 1;
                }
                for (int i = mid + 1; i < end; ++i)
                {
                    midRightSum += a[i];
                    mod = Math.Abs(midRightSum % k);
                    if (midRightSum > r[mod] || rightEnds[mod] == -1)
                    {
                        r[mod] = midRightSum;
                        rightEnds[mod] = i + 1;
                    }
                }

                int[] l = new int[k];
                int[] leftStarts = new int[k];  //left end index array
                for (int i = 0; i < k; ++i)
                {
                    leftStarts[i] = -1;
                }
                int leftSum = 0;
                for (int i = mid - 2; i >= start; --i)
                {
                    leftSum += a[i];
                    mod = Math.Abs(leftSum % k);
                    if (leftSum > l[mod] || leftStarts[mod] == -1)
                    {
                        l[mod] = leftSum;
                        leftStarts[mod] = i;
                    }
                }

                int crossMaxSum = int.MinValue;
                int crossMaxStart = -1;
                int crossMaxEnd = -1;
                if (rightEnds[0] != -1)
                {
                    crossMaxSum = r[0];
                    crossMaxStart = mid - 1;
                    crossMaxEnd = rightEnds[0];
                    if (leftStarts[0] != -1)
                    {
                        int crossSum = l[0] + r[0];
                        if (crossSum > crossMaxSum)
                        {
                            crossMaxSum = crossSum;
                            crossMaxStart = leftStarts[0];
                            crossMaxEnd = rightEnds[0];
                        }
                    }
                }
                for (int i = 1; i < k; ++i)
                {
                    int crossSum = l[i] + r[k - i];
                    if (crossSum > crossMaxSum)
                    {
                        crossMaxSum = crossSum;
                        crossMaxStart = leftStarts[i];
                        crossMaxEnd = rightEnds[k - i];
                    }
                }

                if (crossMaxStart != -1)
                {
                    if (leftMaxStart != -1)
                    {
                        if (rightMaxStart != -1)
                        {
                            if (leftMaxSum >= rightMaxSum && leftMaxSum >= crossMaxSum)
                            {
                                maxStart = leftMaxStart;
                                maxEnd = leftMaxEnd;
                                sum = leftMaxSum;
                            }
                            else if (crossMaxSum >= leftMaxSum && crossMaxSum >= rightMaxSum)
                            {
                                maxStart = crossMaxStart;
                                maxEnd = crossMaxEnd;
                                sum = crossMaxSum;
                            }
                            else
                            {
                                maxStart = rightMaxStart;
                                maxEnd = rightMaxEnd;
                                sum = rightMaxSum;
                            }
                        }
                        else
                        {
                            if (leftMaxSum >= crossMaxSum)
                            {
                                maxStart = leftMaxStart;
                                maxEnd = leftMaxEnd;
                                sum = leftMaxSum;
                            }
                            else
                            {
                                maxStart = crossMaxStart;
                                maxEnd = crossMaxEnd;
                                sum = crossMaxSum;
                            }
                        }
                    }
                    else
                    {
                        if (rightMaxStart != -1)
                        {
                            if (rightMaxSum >= crossMaxSum)
                            {
                                maxStart = rightMaxStart;
                                maxEnd = rightMaxEnd;
                                sum = rightMaxSum;
                            }
                            else
                            {
                                maxStart = crossMaxStart;
                                maxEnd = crossMaxEnd;
                                sum = crossMaxSum;
                            }
                        }
                        else
                        {
                            maxStart = crossMaxStart;
                            maxEnd = crossMaxEnd;
                            sum = crossMaxSum;
                        }
                    }
                }
                else
                {
                    if (leftMaxStart != -1)
                    {
                        if (rightMaxStart != -1)
                        {
                            if (leftMaxSum >= rightMaxSum)
                            {
                                maxStart = leftMaxStart;
                                maxEnd = leftMaxEnd;
                                sum = leftMaxSum;
                            }
                            else
                            {
                                maxStart = rightMaxStart;
                                maxEnd = rightMaxEnd;
                                sum = rightMaxSum;
                            }
                        }
                        else
                        {
                            maxStart = leftMaxStart;
                            maxEnd = leftMaxEnd;
                            sum = leftMaxSum;
                        }
                    }
                    else
                    {
                        if (rightMaxStart != -1)
                        {
                            maxStart = rightMaxStart;
                            maxEnd = rightMaxEnd;
                            sum = rightMaxSum;
                        }
                        else
                        {
                            maxStart = -1;
                            maxEnd = -1;
                            sum = 0;
                        }
                    }
                }
            }
        }
    }
}
