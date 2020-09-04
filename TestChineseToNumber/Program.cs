using System;
using System.Text.RegularExpressions;

namespace TestChineseToNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string number = "一万亿";

            Console.WriteLine(ChineseToNumer(number));
            Console.ReadKey();
        }

        /// <summary>
        /// 转换数字
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        protected static long CharToNumer(char c)
        {
            switch (c)
            {
                case '一': return 1;
                case '二': return 2;
                case '三': return 3;
                case '四': return 4;
                case '五': return 5;
                case '六': return 6;
                case '七': return 7;
                case '八': return 8;
                case '九': return 9;
                case '零': return 0;
                default: return -1;
            }
        }

        /// <summary>
        /// 转换单位
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        protected static long CharToUnit(char c)
        {
            switch (c)
            {
                case '十': return 10;
                case '百': return 100;
                case '千': return 1000;
                case '万': return 10000;
                case '亿': return 100000000;
                default: return 1;
            }
        }

        /// <summary>
        /// 中文数字转阿拉伯数字
        /// </summary>
        /// <param name="cnum"></param>
        /// <returns></returns>
        public static long ChineseToNumer(string cnum)
        {
            cnum = Regex.Replace(cnum, "\\s+", "");
            long firstUnit = 1;
            long secondUnit = 1;
            long result = 0;
            for (int i = cnum.Length - 1; i > -1; --i)
            {
                long tmpUnit = CharToUnit(cnum[i]);
                if (tmpUnit > firstUnit)
                {
                    firstUnit = tmpUnit;
                    secondUnit = 1;
                    if (i == 0)
                    {
                        result += firstUnit * secondUnit;
                    }
                    continue;
                }
                if (tmpUnit > secondUnit)
                {
                    secondUnit = tmpUnit;
                    continue;
                }
                result += firstUnit * secondUnit * CharToNumer(cnum[i]);
            }
            return result;
        }

    }
}
