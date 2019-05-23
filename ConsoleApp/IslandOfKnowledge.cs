using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class IslandOfKnowledge
    {
        protected IslandOfKnowledge() { }

        static void Main()
        {
            int[][] a = { new int[] { 36, 0, 18, 9, 9, 45, 27 },
                          new int[] { 27, 0, 254, 9, 0, 63, 90 },
                          new int[] { 81, 255, 72, 45, 18, 27, 0 },
                          new int[] { 0, 0, 9, 81, 27, 18, 45 },
                          new int[] { 45, 45, 227, 227, 90, 81, 72 },
                          new int[] { 45, 18, 9, 255, 9, 18, 45},
                          new int[] { 27, 81, 36, 127, 255, 72, 81 }
            };

            //Console.WriteLine(avoidObstacles(new int[] { 5, 3, 6, 7, 9 }));
            Console.WriteLine(boxBlur(a));
            Console.ReadKey();
        }

        /// <summary>
        /// Call two arms equally strong if the heaviest weights they each are able to lift are equal.
        /// Call two people equally strong if their strongest arms are equally strong(the strongest arm can be both the right and the left), and so are their weakest arms.
        /// Given your and your friend's arms' lifting capabilities find out if you two are equally strong.
        /// </summary>
        static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            if ((0 > yourLeft && yourLeft > 20) || (0 > yourRight && yourRight > 20)
                || (0 > friendsLeft && friendsLeft > 20) || (0 > friendsRight && friendsRight > 20))
                return false;
            else
                return (yourLeft == friendsLeft && yourRight == friendsRight) || (yourLeft == friendsRight && yourRight == friendsLeft);
        }

        /*
         * Given an array of integers, find the maximal absolute difference between any two of its 
         * adjacent elements.
         */
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

        /*
         * An IP address is a numerical label assigned to each device (e.g., computer, printer) 
         * participating in a computer network that uses the Internet Protocol for communication. 
         * There are two versions of the Internet protocol, and thus two versions of addresses. 
         * One of them is the IPv4 address.
         * 
         * Given a string, find out if it satisfies the IPv4 address naming rules.
         */
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

        /*
         * You are given an array of integers representing coordinates of obstacles situated on a straight line.
         * Assume that you are jumping from the point with coordinate 0 to the right. 
         * You are allowed only to make jumps of the same length represented by some integer.
         * 
         * Find the minimal length of the jump enough to avoid all the obstacles.
         */
        static int avoidObstacles(int[] inputArray)
        {
            int avoid = 0;
            if ((2 > inputArray.Length) || (inputArray.Length > 1000))
                return avoid;
            if (inputArray.Any(x => 1 > x || 1000 < x))
                return avoid;

            for (int j = 2; j < 9999; j++)
            {
                if (!inputArray.Any(x => x % j == 0))
                    return j;
            }
            return avoid;
        }

        /*
         Last night you partied a little too hard. Now there's a black and white photo of you that's 
         about to go viral! You can't let this ruin your reputation, so you want to apply 
         the box blur algorithm to the photo to hide its content.
         
         The pixels in the input image are represented as integers. The algorithm distorts the input 
         image in the following way: Every pixel x in the output image has a value equal to the average 
         value of the pixel values from the 3 × 3 square that has its center at x, including x itself. 
         All the pixels on the border of x are then removed.

         Return the blurred image as an integer, with the fractions rounded down.
          */
        static int[][] boxBlur(int[][] image)
        {
            int refVal = 3;
            int b = image.Length / refVal;
            b = (b * 3) - 1;
            int[][] res;

            for (int i = 0; i < refVal; i++)
            {
                for (int j = 0; j < refVal; j++)
                {

                }
            }
            
            return image;
        }
    }
}
