using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar3.HomeWork3
{
    public class MainHW
    {
        // HW 3.1. Метод проверяет, является ли целое число записанное в переменную n, чётным (true) либо нечётным (false).
        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        // HW 3.2. Метод проверяет, попадает ли переданное число в интервал (25;100) и возвращает true, если попадает, и false - если нет.
        public bool IsInInterval(int number)
        {
            return number > 25 && number < 100;
        }
    }

}
