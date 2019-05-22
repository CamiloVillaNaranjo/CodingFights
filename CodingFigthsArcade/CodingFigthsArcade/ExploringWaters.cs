using System;

namespace CodingFigthsArcade
{
    public class ExploringWaters
    {

        protected ExploringWaters() { }

        static void Main() {
            int[] a = new int[] { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 };
            int[] b = new int[] { 832, 570, 148, 998, 533, 561, 455, 147, 894, 279 };

            Console.WriteLine(areSimilar(a, b));
            Console.ReadLine();
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
    }
}
