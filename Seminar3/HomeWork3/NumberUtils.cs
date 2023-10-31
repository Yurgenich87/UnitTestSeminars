using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar3.HomeWork3
{
    public class NumberUtils
    {
        // Проверяет, является ли число четным.
        public static bool evenOddNumber(int number)
        {
            return number % 2 == 0;
        }
        // Проверяет, попадает ли число в интервал (25, 100).
        public static bool numberInInterval(int number)
        {
            return number > 25 && number < 100;
        }
    }
    

}
