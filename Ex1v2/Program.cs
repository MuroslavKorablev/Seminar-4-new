int WorkWithUser(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine()!);
    return number;
}

int FindSum(int number)
{
    int sum = 0;
    int step = (number > 0) ? 1 : -1; // Определяем направление суммирования

    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i * step;
    }

    if (number == 0)
    {
        return 1; // Сумма от 0 до 1 равна 1.
    }
    else if (number >= 0)
    {
        return sum;
    }
    else
    {
        return 1 + sum; // Добавляем 1 для учета 1 при отрицательных числах.
    }
}

int number1 = WorkWithUser("Введите число A: ");
int summ1 = FindSum(number1);

Console.Write($"Сумма всех чисел от 1 до {number1} равна {FindSum(number1)}");

