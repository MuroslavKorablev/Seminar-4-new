int WorkWithUser(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine()!);
    return number;
}

int Factorial(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i; // Умножаем result на текущее значение i.
    }
    return result;
}

int number = WorkWithUser("Введите число: ");
int result = Factorial(number);

System.Console.WriteLine($"Факториал {number} = {result}");