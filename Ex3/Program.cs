int WorkWithUser(string message)
{
    System.Console.Write(message);
    int number = int.Parse(System.Console.ReadLine()!);
    return number;
}