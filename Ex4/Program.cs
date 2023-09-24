// int[] array = new int[8];
//  Random random = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(0, 2);
//     System.Console.Write(array[i] + " ");    
// }

// Заполнение и вывод массива из 8 элементов случайными числами 0 и 1
int[] numbers = new int[8];
Random random = new Random(); // Создание объекта Random
FillArray(numbers, random);
PrintArray(numbers);

void FillArray(int[] array, Random random)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(2); // Использование одного и того же объекта Random 
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        System.Console.Write(collection[i] + " ");
    }
}