using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(closestTo100(50,75));
            Console.WriteLine(reverseInParentheses("foo(bar(baz))blim"));
            Console.ReadKey();
        }

        static string reverseInParentheses(string inputString)
        {
            if (0 > inputString.Trim().Length || inputString.Trim().Length > 50)
                return "";

            if (inputString.IndexOf('(') == -1)
                return inputString;
            else
            {
                string sr1 = "";
                string sr2 = "";
                string sr3 = "";
                int f = inputString.IndexOf('(');
                int f2 = inputString.LastIndexOf('(');
                int l = inputString.IndexOf(')');
                int l2 = inputString.LastIndexOf(')');

                if (l > f)
                {
                    sr1 = inputString.Substring(0, f);
                    sr2 = new string(inputString.Substring(f + 1, l - f - 1).Reverse().ToArray());
                    sr3 = inputString.Substring(l + 1);
                }
                else if (l > f2)
                {
                    sr1 = inputString.Substring(0, f2);
                    sr2 = new string(inputString.Substring(f2 + 1, l - f2 - 1).Reverse().ToArray());
                    sr3 = inputString.Substring(l + 1);
                }
                else if(l2>f2)
                {
                    sr1 = inputString.Substring(0, f2);
                    sr2 = new string(inputString.Substring(f2 + 1, l2 - f2 - 1).Reverse().ToArray());
                    sr3 = inputString.Substring(l2 + 1);
                }
                else
                    return string.Empty;

                return reverseInParentheses(sr1
                    + sr2
                    + sr3);
            }
        }

        static int[] longestUncorruptedSegment(int[] sourceArray, int[] destinationArray)
        {
            int sC = 0, pC = 0;

            for (int i = 0; i < sourceArray.Length; i++)
            {
                if (sourceArray[i] != destinationArray[i])
                {
                    sC = i;
                }
            }

            var corrupted = sourceArray[sC].ToString().Length;

            for (int j = 0; j < corrupted; j++)
            {
                if (sourceArray[sC].ToString()[j] != destinationArray[sC].ToString()[j])
                {
                    pC = j;
                }
            }

            return new int[] { pC + 1, sC + 1 };
        }

        static bool areSimilar(int[] a, int[] b)
        {
            int swaps = 0;
            int cE = 0;
            if (3 > a.Length || a.Length > (long)Math.Pow(10, 5))
                return false;
            else if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        swaps += 1;
                    }
                    else
                    {
                        cE += 1;
                    }
                }

                if (swaps > 2) return false;
                else
                {
                    swaps = 0;
                    a = a.OrderBy(x => x).ToArray();
                    b = b.OrderBy(x => x).ToArray();

                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] != b[i])
                        {
                            swaps += 1;
                        }
                    }
                    return swaps == 0;
                }
            }
            else
            {
                return false;
            }
        }

        static int firstDuplicate(int[] a)
        {
            if ((a.Length < 1) || (a.Length > 100000)) return -1;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] < 1) || (a[i] > a.Length)) return -1;
            }
            var g = a.Select((v, i) => new { Ix = i, Vr = v }).GroupBy(y => y.Vr).Where(x => x.Count() > 1).Select(c => c.Key).ToArray();
            var b = new List<myArr>();
            for (int i = 0; i < g.Length; i++)
            {
                b.Add(new myArr(g[i], Array.IndexOf(a, g[i])));
            }

            return b.OrderBy(x => x.p).FirstOrDefault().v;
        }

        static int closestTo100(int a, int b)
        {
            int refVal = 100;
            int ac = Math.Abs(refVal- a);
            int bc = Math.Abs(refVal - b);

            if (ac == bc)
                return 0;
            else
                return ac < bc ? a : b;
        }

        static int myFunc(int a)
        {
            return a > 10 && 100 < a ? a : 0;
        }

        static bool reachNextLevel(int experience, int threshold, int reward)
        {
            return experience+reward>=threshold;
        }
    }

    public class myArr
    {
        public int v { get; set; }
        public int p { get; set; }

        public myArr(int a, int b)
        {
            v = a;
            p = b;
        }
    }
}
