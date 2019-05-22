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
            bool result = false;

            int cE = 0;
            int cD = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                    cE++;
                else
                    cD++;
                
            }

            if (cE > cD && cD <= 2) result = true;

            return result;
        }
    }
}
