int WorkWithUser(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine()!);
    return number;
}
int FindSum(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int num = WorkWithUser("Введите число A: ");
System.Console.Write($"Сумма всех чисел от 1 до {num} равна {FindSum(num)}");
