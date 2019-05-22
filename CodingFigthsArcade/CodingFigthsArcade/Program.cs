using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingFigthsArcade
{
    class Program
    {

        protected Program() { }

        static void Main()
        {

            //int[] a = { 1, 3, 2, 1 };

            //Console.WriteLine(almostIncreasingSequence(a));

            //int[] b = { 1, 3, 2};
            //Console.WriteLine(almostIncreasingSequence(b));

            //int[] c = { 1, 2, 3, 4, 99, 5, 6 };
            //Console.WriteLine(almostIncreasingSequence(c));

            //int[] a = {6,2,3,8};
            //Console.WriteLine(makeArrayConsecutive2(a));
            //int[] b = { 6,3 };
            //Console.WriteLine(makeArrayConsecutive2(b));
            //int[] c = { 5,4,6 };
            //Console.WriteLine(makeArrayConsecutive2(c));
            //int[] d = { 0, 3 };
            //Console.WriteLine(makeArrayConsecutive2(d));

            //Console.WriteLine(shapeArea(2));
            //Console.WriteLine(shapeArea(3));
            //Console.WriteLine(shapeArea(4));
            //Console.WriteLine(shapeArea(5));
            //Console.WriteLine(shapeArea(6));

            //int[] b = { -1 };
            //Console.WriteLine(adjacentElementsProduct(b));
            //int[] c = { -1, 3, -4, 5, 1, -6, 2, 1,7,10,-10000 };
            //Console.WriteLine(adjacentElementsProduct(c));
            //int[] d = { -1000, 3, -4, 5, 1, -6, 2, 1,1000 };
            //Console.WriteLine(adjacentElementsProduct(d));

            //int[][] matA = new int[][] { new int[] { 0, 1, 1, 2 }, new int[] { 0, 5, 0, 0 }, new int[] { 2, 0, 3, 3 } };
            //Console.WriteLine(matrixElementsSum(matA));
            int[][] matB = new int[][] { new int[] { 1, 1, 1, 0 }, new int[] { 0, 5, 0, 1 }, new int[] { 2, 1, 3, 10 } };
            Console.WriteLine(matrixElementsSum(matB));
            Console.WriteLine(hintArcade(matB));

            Console.ReadKey();
        }

        public static bool Solution(int[] A) {
            //Sort an integer array in non-decreasing order with single swap

            int temp;
            int swaps = 0;
            int iterations = 0;
            int i;
            bool flag = true;

            while (flag)
            {
                flag = false;
                i = 0;
                iterations++;
                while (i < A.Length - 1)
                {
                    if (A[i] > A[i + 1])
                    {
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swaps++;
                        flag = true;
                    }
                    i++;
                }
            }

            flag = swaps > 0;

            return flag;
        }
        
        public static int Solution2(int[] A, int N)
        {
            if (A.Length == 0)
                return -1;
            int pref = 0;
            int suf = 0;

            int i, j;
            try
            {
                for (i = 0; i < N; i++)
                {
                    pref = 0;
                    for (j = 0; j < i; j++)
                    {
                        pref += A[j];
                    }
                    suf = 0;
                    for (j = i+1; j < A.Length; j++)
                    {
                        suf += A[j];
                    }
                    if(pref == suf)
                    {
                        return i;
                    }
                }
            }
            catch (ArithmeticException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }

            return -1;
        }

        public static int centuryFromYear(int year)
        {
            if (year < 1 || year > 2005)
                return 0;
            if (year >= 1 && year <= 100)
                return 1;
            if (year >= 101 && year <= 200)
                return 2;
            if (year >= 201 && year <= 300)
                return 3;
            if (year >= 301 && year <= 400)
                return 4;
            if (year >= 401 && year <= 500)
                return 5;
            if (year >= 501 && year <= 600)
                return 6;
            if (year >= 601 && year <= 700)
                return 7;
            if (year >= 701 && year <= 800)
                return 8;
            if (year >= 801 && year <= 900)
                return 9;
            if (year >= 901 && year <= 1000)
                return 10;
            if (year >= 1001 && year <= 1100)
                return 11;
            if (year >= 1101 && year <= 1200)
                return 12;
            if (year >= 1201 && year <= 1300)
                return 13;
            if (year >= 1301 && year <= 1400)
                return 14;
            if (year >= 1401 && year <= 1500)
                return 15;
            if (year >= 1501 && year <= 1600)
                return 16;
            if (year >= 1601 && year <= 1700)
                return 17;
            if (year >= 1701 && year <= 1800)
                return 18;
            if (year >= 1801 && year <= 1900)
                return 19;
            if (year >= 1901 && year <= 2000)
                return 20;
            if (year >= 2001 && year <= 2100)
                return 21;
            if (year >= 2101 && year <= 2200)
                return 22;
            if (year >= 2201 && year <= 2300)
                return 23;
            if (year >= 2301 && year <= 2400)
                return 24;
            if (year >= 2401 && year <= 2500)
                return 25;
            if (year >= 2501 && year <= 2600)
                return 26;
            if (year >= 2601 && year <= 2700)
                return 27;
            if (year >= 2701 && year <= 2800)
                return 28;
            if (year >= 2801 && year <= 2900)
                return 29;
            if (year >= 2901 && year <= 3000)
                return 30;
            else
                return year % 100 == 0 ? year/100 : (year / 100) + 1;

        }

        public static bool checkPalindrome(string inputString)
        {
            string reverso = "";
            if (inputString.Length < 1 || inputString.Length > 10)
                return false;

            foreach (var item in inputString.Reverse())
            {
                reverso += item.ToString();
            }
            if (reverso == inputString)
                return true;
            else
                return false;
        }

        public static int adjacentElementsProduct(int[] inputArray)
        {
            int result = 0;
            if (inputArray.Length < 2 && inputArray.Length > 10)
                return result;
            else
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] < -1000 && inputArray[i] > 1000)
                    {
                        return result;
                    }
                }
                result = (inputArray[0] * inputArray[1]);
                for (int i = 0; i < inputArray.Length-1; i++)
                {
                    if (result < (inputArray[i] * inputArray[i + 1]))
                        result = (inputArray[i] * inputArray[i + 1]);
                }
            }

            return result;
        }

        public static int shapeArea(int n)
        {
            int result = 0;
            if(n<1 && n>Math.Pow(10,4))
            {
                return result;
            }
            for (int i = 0; i < n; i++)
            {
                if (i + 1 == 1)
                    result += 1;
                else
                    result += (4 * i);
            }

            return result;
        }


        /*
         * Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, 
         * each statue having an non-negative integer size. Since he likes to make things perfect, 
         * he wants to arrange them from smallest to largest so that each statue will be bigger than 
         * the previous one exactly by 1. He may need some additional statues to be able to accomplish that. 
         * Help him figure out the minimum number of additional statues needed.
         */
        public static int makeArrayConsecutive2(int[] statues)
        {
            int result = 0;

            if (statues.Length <= 1 && statues.Length > 10)
                return result;

            var ordered = statues.OrderBy(c=>c).ToArray();

            for (int i = 0; i < statues.Length; i++)
            {
                if (statues[i] < 0 && statues[i] > 20)
                    result = 0;
                if ((i + 1 < statues.Length) && (ordered[i + 1] - ordered[i]) > 1)
                    result += (ordered[i + 1] - ordered[i]) - 1;
            }

            return result;
        }

        /*
         * Given a sequence of integers as an array, determine whether 
         * it is possible to obtain a strictly increasing sequence by 
         * removing no more than one element from the array.
         */
        public static bool almostIncreasingSequence(int[] sequence)
        {
            int cont = 0;
            int MaxLimit = sequence.Length;

            if (2 < MaxLimit && MaxLimit > Math.Pow(10, 5))
                return false;
            if (MaxLimit == 2 && sequence[0] < sequence[1])
                return true;

            for (int i = 0; (cont < 2) && (i < MaxLimit -1 ) ; ++i)
            {
                if (Math.Pow(-10, 5) > sequence[i] 
                    && sequence[i] > Math.Pow(10, 5))
                    return false;
                if (sequence[i] >= sequence[i+1])
                {
                    ++cont;
                    if (((i - 1) >= 0) && (sequence[i - 1] >= sequence[i + 1]))
                    {
                        if ((i+2)<MaxLimit && sequence[i] >= sequence[i+2])
                            return false;
                    }
                }
            }
            return cont > 1 ? false : true;
        }

        /*
         * 
         */
        

        /*
         * Given a binary tree t, determine whether it is symmetric around its center, 
         * i.e. each side mirrors the other.
         */
         public static bool isTreeSymmetric(Tree<int> t)
        {
            bool response = false;
            var ts = treeSize(t);


            if (0 > ts && ts > (5 * Math.Pow(10, 4)))
            {
                if (ts == 0)
                    return true;
                return false;
            }
            response = validateNodeValue(t);

            if (response && t != null)
            {
                response = mirrorEquals(t.left, t.right);
            }

            return response;
        }

        private static int treeSize (Tree<int> t)
        {
            if (t == null)
                return 0;
            int leftSize = treeSize(t.left);
            int rightSize = treeSize(t.right);
            if(leftSize>rightSize)
                return leftSize + 1;
            else
                return rightSize + 1;
        }

        private static bool validateNodeValue(Tree<int> t)
        {
            if (t != null)
            {
                if (-1000 > t.value && 1000 < t.value)
                    return false;
                else
                {
                    bool leftNodeVal = validateNodeValue(t.left);
                    bool rightNodeVal = validateNodeValue(t.right);
                    return leftNodeVal && rightNodeVal;
                }
            }
            else
                return true;
        }

        private static bool mirrorEquals(Tree<int> tleft, Tree<int> tright)
        {
            if (tleft == null || tright == null)
                return (tleft == null && tright == null);
            else
                return (tleft.value == tright.value
                    && mirrorEquals(tleft.left, tright.right)
                    && mirrorEquals(tleft.right, tright.left));
        }

        public static string[] findSubstrings(string[] words, string[] parts)
        {
            throw new NotImplementedException();
        }

        /* After becoming famous, CodeBots decided to move to a new building 
         * and live together. The building is represented by a rectangular 
         * matrix of rooms, each cell containing an integer - the price of the room. 
         * Some rooms are free (their cost is 0), but that's probably because 
         * they are haunted, so all the bots are afraid of them. That is why any room 
         * that is free or is located anywhere below a free room in the same column 
         * is not considered suitable for the bots.
         * Help the bots calculate the total price of all the rooms that are suitable 
         * for them.
         */
        static int matrixElementsSum(int[][] matrix)
        {
            var mySum = 0;
            var ml = matrix.Length;
            var freaky = new List<string>();
            var suit = new List<string>();
            try
            {
                if (1 > ml && ml > 5)
                {
                    return 0;
                }
                else
                {
                    var rl = matrix[0].Length;
                    if (1 > rl && rl > 5) return 0;
                    for (int i = 0; i < ml; i++)
                    {
                        for (int j = 0; j < rl; j++)
                        {
                            var cost = matrix[i][j];
                            if (0 > cost && cost > 10) return 0;
                            if (cost == 0)
                            {
                                if (!freaky.Contains(string.Format("{0},{1}", i, j)))
                                    freaky.Add(string.Format("{0},{1}", i, j));

                                for (int k = i+1; k < rl; k++)
                                {
                                    if (!freaky.Contains(string.Format("{0},{1}", k, j)))
                                        freaky.Add(string.Format("{0},{1}", k, j));
                                }
                            }
                            else
                            {
                                if (!freaky.Contains(string.Format("{0},{1}", i, j)))
                                    suit.Add(string.Format("{0},{1}", i, j));
                            }
                        }
                    }

                    foreach (var item in suit)
                    {
                        var pos = item.Split(',');
                        mySum += matrix[Convert.ToInt32(pos[0])][Convert.ToInt32(pos[1])];
                    }
                }
                return mySum;
            }
            catch (Exception)
            {
                return mySum;
            }
        }


        static int hintArcade(int[][] matrix) {
            int mySum = 0;
            for (int i = 0; i < matrix[0].Length; i++)
                for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
                    mySum += matrix[j][i];

            return mySum;
        }
}
}
