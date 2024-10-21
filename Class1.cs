public class CalculatorFunctions
{
    public double Addition(double a, double b)
    {
        return a + b;
    }

    public double Subtraction(double a, double b)
    {
        return a - b;
    }

    public double Division(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль невозможно");
        }
        return a / b;
    }

    public double Multiplication(double a, double b)
    {
        return a * b;
    }

    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Modulus(double a, double b)
    {
        return a % b;
    }

    public double Square(double a)
    {
        return a * a;
    }

    public double SquareRoot(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Корень из отрицательного числа не определен");
        }
        return Math.Sqrt(a);
    }

    public double Max(double a, double b)
    {
        return Math.Max(a, b);
    }

    public double Min(double a, double b)
    {
        return Math.Min(a, b);
    }

    public double Percentage(double a, double b)
    {
        return (a / 100) * b;
    }

    public double Absolute(double a)
    {
        return Math.Abs(a);
    }
}
