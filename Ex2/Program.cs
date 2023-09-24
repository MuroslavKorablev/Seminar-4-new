int WorkWithUser(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine()!);
    return number;
}

int countDigit(int number)
{
    int count = 0;
    while (number != 0)
{
    count++;
    number = number / 10;
}
    return count;
}

int number = WorkWithUser("Введите число: ");
int count = countDigit(number);
System.Console.WriteLine($"В числе {number} количество цифр равно: {count}");
