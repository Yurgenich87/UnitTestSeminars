using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar3.Homework3
{
    public class SomeService
    {
        /**
         * 3.1. Метод возвращает Fizz для чисел кратных 3, Buzz для кратных 5, и FizzBuzz для кратных 3 и 5 одновременно
         */
        public string FizzBuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            return null; // Если число не делится ни на 3, ни на 5, вернем null
        }

        /**
         * 3.2. Метод возвращает true для массивов, которые начинаются или заканчиваются 6, и false - если 6 нет ни в начале ни в конце массива
         */
        public bool FirstLast6(int[] nums)
        {
            if (nums.Length > 0 && (nums[0] == 6 || nums[nums.Length - 1] == 6))
            {
                return true;
            }
            return false;
        }

        /**
         * 3.3. Метод подсчета скидки
         */
        public double CalculatingDiscount(double purchaseAmount, int discountAmount)
        {
            if (purchaseAmount > discountAmount)
            {
                return purchaseAmount - discountAmount;
            }
            return purchaseAmount;
        }

        /**
         * 3.4. Метод принимает на вход 3 числа (int a, b, c). Нужно вернуть их сумму. Однако, если одно из значений равно 13,
         * то оно не учитывается в сумме. Так, например, если b равно 13, то считается сумма только a и c.
         */
        public int SumWithout13(int a, int b, int c)
        {
            if (a == 13)
            {
                return c;
            }
            if (b == 13)
            {
                return a + c;
            }
            if (c == 13)
            {
                return a + b;
            }
            return a + b + c;
        }
    }

}
