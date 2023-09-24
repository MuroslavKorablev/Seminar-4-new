int WorkWithUser(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine()!);
    return number;
}

int countDigits(int number)
{
    if (number == 0)
    {
        return 1; // Если число равно 0, возвращаем 1.
    }

    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number = number / 10;
        }
        return count;
    }
}
int number = WorkWithUser("Введите число: ");
int count = countDigits(number);
System.Console.WriteLine($"В числе {number} количество цифр равно: {count}");
