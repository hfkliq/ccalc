using System;

class Calculator
{
    private double num1, num2;
    private CalculatorFunctions calculatorFunctions;

    public Calculator()
    {
        calculatorFunctions = new CalculatorFunctions();
    }

    public void Start()
    {
        Console.WriteLine("Введите первое число:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Деление");
        Console.WriteLine("4 - Умножение");
        Console.WriteLine("5 - Возведение в степень");
        Console.WriteLine("6 - Остаток от деления");
        Console.WriteLine("7 - Возведение в квадрат (только для первого числа)");
        Console.WriteLine("8 - Квадратный корень (только для первого числа)");
        Console.WriteLine("9 - Максимум из двух чисел");
        Console.WriteLine("10 - Минимум из двух чисел");
        Console.WriteLine("11 - Вычисление процента");
        Console.WriteLine("12 - Модуль числа (только для первого числа)");

        int choice = Convert.ToInt32(Console.ReadLine());

        ExecuteOperation(choice);
    }

    private void ExecuteOperation(int choice)
    {
        try
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Результат: " + calculatorFunctions.Addition(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Результат: " + calculatorFunctions.Subtraction(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Результат: " + calculatorFunctions.Division(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Результат: " + calculatorFunctions.Multiplication(num1, num2));
                    break;
                case 5:
                    Console.WriteLine("Результат: " + calculatorFunctions.Power(num1, num2));
                    break;
                case 6:
                    Console.WriteLine("Результат: " + calculatorFunctions.Modulus(num1, num2));
                    break;
                case 7:
                    Console.WriteLine("Результат: " + calculatorFunctions.Square(num1));
                    break;
                case 8:
                    Console.WriteLine("Результат: " + calculatorFunctions.SquareRoot(num1));
                    break;
                case 9:
                    Console.WriteLine("Результат: " + calculatorFunctions.Max(num1, num2));
                    break;
                case 10:
                    Console.WriteLine("Результат: " + calculatorFunctions.Min(num1, num2));
                    break;
                case 11:
                    Console.WriteLine("Результат: " + calculatorFunctions.Percentage(num1, num2));
                    break;
                case 12:
                    Console.WriteLine("Результат: " + calculatorFunctions.Absolute(num1));
                    break;
                default:
                    Console.WriteLine("Неправильный выбор операции.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }

    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Start();
    }
}
