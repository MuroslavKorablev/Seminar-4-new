System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int sum = 0;
if (num >= 0)
{
    for (int i = 1; i <= num; i++)
    {
        // Добавляем текущее значение i к сумме.
        sum += i;
    }
}
else
{
    for (int i = 1; i >= num; i--)
    {
        // Добавляем текущее значение i к сумме.
        sum += i;
    }
}

System.Console.WriteLine("Сумма всех чисел от 1 до " + num + " равна " + sum);
