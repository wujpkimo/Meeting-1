using System;

namespace cherss
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] number = { "零", "壹", "貳", "參", "肆", "伍", "陸", "柒", "捌", "玖" };

            string x = "叫我第一名";
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            int y = 12345;

            Console.WriteLine(number[int.Parse(y.ToString()[0].ToString())]);

            char[] xxx = new char[] { '叫' };

            int[] i = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(i[0]);
        }
    }
}