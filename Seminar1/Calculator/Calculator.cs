using System;

namespace Seminar1.Calculator
{
    public class Calculator
    {
        public static int Calculation(int firstOperand, int secondOperand, char @operator)
        {
            int result;

            switch (@operator)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    if (secondOperand != 0)
                    {
                        result = firstOperand / secondOperand;
                        break;
                    }
                    else
                    {
                        throw new DivideByZeroException("Division by zero is not possible");
                    }
                default:
                    throw new InvalidOperationException("Unexpected value operator: " + @operator);
            }
            return result;
        }

        // HW1.1: Псевдокод для извлечения корня
        public static double SquareRootExtraction(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number");
            }
            return Math.Sqrt(num);
        }

        // Метод для вычисления суммы покупки со скидкой
        public static double CalculatingDiscount(double purchaseAmount, int discountAmount)
        {
            if (discountAmount < 0 || discountAmount > 100)
            {
                throw new ArgumentException("Discount amount must be between 0 and 100");
            }

            double discount = (double)discountAmount / 100;
            double discountedAmount = purchaseAmount * (1 - discount);

            return discountedAmount;
        }
    }
}
