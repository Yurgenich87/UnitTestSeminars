using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar3
{

        public class Calculator
    {
        // Метод для получения оператора от пользователя
        public static char GetOperator()
        {
            Console.WriteLine("Enter operation: ");
            char operation = Console.ReadKey().KeyChar;
            return operation;
        }

        // Метод для получения операнда (числа) от пользователя
        public static int GetOperand()
        {
            Console.WriteLine("Enter operand: ");
            int operand;
            if (int.TryParse(Console.ReadLine(), out operand))
            {
                return operand;
            }
            else
            {
                Console.WriteLine("You have mistaken, try again");
                return GetOperand();
            }
        }

        // Метод для выполнения математической операции (+, -, *, /) над двумя операндами
        public static int Calculation(int firstOperand, int secondOperand, char operation)
        {
            int result;

            switch (operation)
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
                    break;
                default:
                    throw new InvalidOperationException("Unexpected operation value: " + operation);
            }

            return result;
        }

        // Метод для вычисления квадратного корня
        public static double SquareRootExtraction(double number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException("Square root extraction is not possible for negative numbers");
            }

            return Math.Sqrt(number);
        }

        // Метод для вычисления суммы покупки с учетом скидки
        public static double CalculatingDiscount(double purchaseAmount, int discountAmount)
        {
            if (purchaseAmount < 0)
            {
                throw new InvalidOperationException("Purchase amount cannot be negative");
            }

            if (discountAmount < 0 || discountAmount > 100)
            {
                throw new InvalidOperationException("Discount should be in the range of 0 to 100%");
            }

            double discountedAmount = purchaseAmount - (purchaseAmount * discountAmount) / 100;

            return discountedAmount;
        }

        // Метод для возведения числа в степень
        public static int Pow(int value, int powValue)
        {
            int result = 1;

            for (int a = 1; a <= powValue; a++)
            {
                if (a == 0)
                {
                    return 1;
                }

                result = result * value;
            }

            return result;
        }

        // Метод для вычисления площади круга по радиусу
        public double ComputeAreaCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Метод для вычисления длины окружности по радиусу
        public double ComputeLengthCircle(int r)
        {
            return 2 * Math.PI * r;
        }

        public static void Main(string[] args)
        {
            // Пример использования методов
            int firstOperand = GetOperand();
            int secondOperand = GetOperand();
            char operation = GetOperator();
            int result = Calculation(firstOperand, secondOperand, operation);
            Console.WriteLine("Operation result is: " + result);

            Console.WriteLine(CalculatingDiscount(100, 25));
        }
    }


}
