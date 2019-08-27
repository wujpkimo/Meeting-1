using System;

namespace NumberToCHT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToChinese(12345));
        }


        static string ToChinese(int value)
        {
            string[] number = new string[] {"零","壹","貳","參","肆","伍","陸","柒","捌","玖" };
            string[] u = new string[] { "", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "兆", "拾" };

            string tmp = value.ToString();
            string result = "";
            for (int i = 0; i <= tmp.Length-1; i++)
            {
                result += number[int.Parse(tmp[i].ToString())];

                result += u[int.Parse(tmp[i].ToString())];
            }
            return result;
        }
    }
}
