System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

double Factorial(int num)
{
    if (num < 0)
    {
        // Факториал отрицательных чисел не определен, вернем какое-то значение (например, NaN).
        return double.NaN;
    }
    else if (num == 0)
    {
        // Факториал 0 равен 1.
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}

if (num >= 0)
{
    double result = Factorial(num);
    System.Console.WriteLine($"Факториал числа {num} равен {result}");
}
else
{
    System.Console.WriteLine("Введите неотрицательное число для вычисления факториала.");
}