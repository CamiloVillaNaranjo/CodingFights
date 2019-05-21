using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(firstDuplicate(new int[] { 1,1,2,2,1}));
            Console.ReadKey();
        }

        static string reverseInParentheses(string inputString)
        {
            if (inputString.IndexOf('(') == -1)
                return inputString;
            else
            {
                string sr1 = "";
                string sr2 = "";
                int f = inputString.LastIndexOf('(');
                int f2 = inputString.IndexOf('(');
                int l = inputString.IndexOf(')');

                if (l > f)
                {
                    sr1 = inputString.Substring(0, f);
                    sr2 = new string(inputString.Substring(f + 1, l - f - 1).Reverse().ToArray());
                }
                else
                {
                    sr1 = inputString.Substring(0, f2);
                    sr2 = new string(inputString.Substring(f2 + 1, l - f2 - 1).Reverse().ToArray());
                }

                return reverseInParentheses(sr1
                    + sr2
                    + inputString.Substring(l + 1));
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

        static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            if ((0 > yourLeft && yourLeft > 20) || (0 > yourRight && yourRight > 20)
                || (0 > friendsLeft && friendsLeft > 20) || (0 > friendsRight && friendsRight > 20))
                return false;
            else
                return (yourLeft == friendsLeft && yourRight == friendsRight) || (yourLeft == friendsRight && yourRight == friendsLeft);
        }

        static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            if ((inputArray.Length < 3) || (inputArray.Length > 10))
                return 0;

            if (inputArray.Any(x => x < -15 || x > 15))
                return 0;

            var arr = new int[inputArray.Length - 1];
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                arr[i] = Math.Abs(inputArray[i] - inputArray[i + 1]);
            }

            return arr.Max();
        }

        static bool isIPv4Address(string inputString)
        {
            if ((1 > inputString.Length) || (inputString.Length > 30))
                return false;
            var tectos = inputString.Split('.');
            if ((tectos.Length < 4) || (tectos.Length > 4))
                return false;
            for (int i = 0; i < 4; i++)
            {
                int numero = 0;
                if (string.IsNullOrEmpty(tectos[i].Trim()) || !int.TryParse(tectos[i].Trim(), out numero))
                    return false;
                else if ((int.Parse(tectos[i].Trim()) < 0) || (int.Parse(tectos[i].Trim()) > 255))
                    return false;
            }
            return true;
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
