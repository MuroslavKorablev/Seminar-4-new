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

int number1 = WorkWithUser("Введите число A: ");
int summ1 = FindSum(number1);
// int number2 = WorkWithUser("Введите число B: ");
// int summ2 = FindSum(number2);
// int number3 = WorkWithUser("Введите число C: ");
// int summ3 = FindSum(number3);


// Console.Write($"{summ1} + {summ2} + {summ3} = {summ1 + summ2 + summ3}");
Console.Write($"Сумма всех чисел от 1 до {number1} равна {FindSum(number1)}");

