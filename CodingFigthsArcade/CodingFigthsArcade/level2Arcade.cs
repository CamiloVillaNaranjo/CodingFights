using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingFigthsArcade
{
    class Level2Arcade
    {
        protected Level2Arcade() { }

        static void Main()
        {
            //string[] tokens_a0 = Console.ReadLine().Split(' ');

            //Console.WriteLine(allLongestStrings(tokens_a0));
            //int[] A = new int[] { -1, 150, 190, 170, -1, -1, 160, 180 };
            //Console.WriteLine(sortByHeight(A));

            //int k = 17;
            //Console.WriteLine(totalOr(k));
            //int j = 2147483647;
            //Console.WriteLine(totalOr(j));

            string e = "abc(cba)ab(bac)c";
            Console.WriteLine(reverseParentheses(e));

            Console.ReadKey();
        }

        static string[] allLongestStrings(string[] inputArray)
        {
            var res = new List<string>();
            try
            {
                if(1 <= inputArray.Length && inputArray.Length <=10)
                {
                    if(inputArray.Length == 1) return inputArray;
                    int minLen = inputArray[0].Length;
                    int maxLen = inputArray[0].Length;
                    foreach (var item in inputArray)
                    {
                        if(1 <= item.Length && item.Length <= 10)
                        {
                            if (item.Length < minLen) { minLen = item.Length; }
                            if (item.Length > maxLen) { maxLen = item.Length; }
                        }
                    }
                    res.AddRange(inputArray.Where(x => x.Length > ((minLen + maxLen) / 2)));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return res.ToArray<string>();
        }
        static int commonCharacterCount(string s1, string s2)
        {
            int cont = 0;
            var common = new List<string>();
            if (s1.Length < 3 && s1.Length > 15) return cont;

            if (s2.Contains(s1)) return s1.Length;

            for (int i = 0; i < s1.Length; i++)
            {
                var index = s2.IndexOf(s1[i]);
                if(index > -1)
                {
                    s2 = s2.Remove(index, 1);
                    cont++;
                }
            }

            return cont;
        }

        static bool isLucky(int n)
        {
            var arr = n.ToString().ToArray();
            int mid = arr.Length / 2;
            int fmid = 0;
            int smid = 0;
            for (int i = 0; i < mid; i++)
            {
                fmid += arr[i];
            }
            for (int i = mid; i < arr.Length; i++)
            {
                smid += arr[i];
            }
            return fmid == smid;
        }

        static int[] sortByHeight(int[] a)
        {
            if (a.Length < 5 && a.Length > 15) return new int[] { 0 };
            int[] res = new int[a.Length];
            int min = a.Max();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < -1 && a[i] > 200) return new int[] { 0 };
                else
                {
                    if (!a.Contains(-1))
                    {
                        return (from el in a orderby el ascending select el).ToArray();
                    }
                    else
                    {
                        if (a[i] == -1)
                            res[i] = a[i];
                        else
                        {
                            for (int j = i; j < a.Length; j++)
                            {
                                if (min > a[j] && a[j] != -1) min = a[j];
                            }
                            int ind = Array.IndexOf(a, min);
                            a[ind] = a[i];
                            a[i] = min;
                            res[i] = min;
                            min = a.Max();
                        }
                    }
                }
            }

            return res.ToArray();
        }

        static int totalOr(int k)
        {
            int r = 0;
            int i = 0;
            while (i < k)
            {
                if (i + 1 <= k) r = r | i + 1;
                if (i + 2 <= k) r = r | i + 2;
                i++;
            }
            return r;
        }

        static string reverseParentheses(string s)
        {
            Stack<int> idx = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') idx.Push(i);
                else
                    if (s[i] == ')')
                {
                    s = insideParentheses(s, idx.Pop(), i);
                    i -= 2;
                }
            }
            return s;
        }
        static string insideParentheses(string s, int a, int b)
        {
            string s2 = "";
            for (int i = b - 1; i > a; i--)
                s2 += s[i];
            return s.Substring(0, a) + s2 + s.Substring(b + 1);
        }
        
        string reverseParentheses2(string s)
        {
            Stack<int> indx = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') indx.Push(i);
                else if (s[i] == ')')
                {
                    s = Anverso(s, indx.Pop(), i);
                    i -= 2;
                }
            }
            return s;
        }

        string Anverso(string s, int a, int b)
        {
            string s2 = string.Empty;
            for (int i = b - 1; b > a; i--)
                s2 += s[i];
            return s.Substring(0, a) + s2 + s.Substring(b + a);
        }
    }
}
