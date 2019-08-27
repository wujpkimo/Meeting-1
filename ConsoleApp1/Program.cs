using System;
using System.Collections;
using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int 總分;
            int 平均;
            string 等第;
            //....

            #region Code

            Score score = new Score(100, 90, 80);
            總分 = score.sum;
            平均 = score.average;
            等第 = score.level;
            Console.WriteLine($"{總分} , {平均} , {等第}");

            getScore1(100, 90, 80, out 總分, out 平均, out 等第);
            Console.WriteLine($"{總分} , {平均} , {等第}");

            (總分, 平均, 等第) = getScore(100, 80, 50);
            Console.WriteLine($"{總分} , {平均} , {等第}");

            #endregion Code
        }

        /// <summary>
        /// xx
        /// </summary>
        /// <param name="國文">國文</param>
        /// <param name="英文">英文</param>
        /// <param name="數學">數學</param>
        /// <returns>總分,平均,等第</returns>
        private static (int, int, string) getScore(int 國文, int 英文, int 數學)
        {
            int sum = 國文 + 英文 + 數學;
            int average = sum / 3;
            string level;
            if (sum >= 90)
                level = "A+";
            else if (sum >= 80)
                level = "A";
            else if (sum >= 70)
                level = "B";
            else
                level = "C";
            return (sum, average, level);
        }

        private static void getScore1(int 國文, int 英文, int 數學, out int x, out int y, out string z)
        {
            x = 國文 + 英文 + 數學;
            y = x / 3;
            if (x >= 90)
                z = "A+";
            else if (x >= 80)
                z = "A";
            else if (x >= 70)
                z = "B";
            else
                z = "C";
        }

        private class Score
        {
            public int sum;
            public int average;
            public string level;

            public Score(int 國文, int 英文, int 數學)
            {
                sum = 國文 + 英文 + 數學;
                average = sum / 3;
                if (sum >= 90)
                    level = "A+";
                else if (sum >= 80)
                    level = "A";
                else if (sum >= 70)
                    level = "B";
                else
                    level = "C";
            }
        }
    }

    internal class MyClass
    {
        public (int, int) TestTuple()
        {
            return (1, 2);
        }
    }
}