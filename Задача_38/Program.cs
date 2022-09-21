// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

const int Size = 5;
int[] array = CreateArray(Size);
PrintArray(array);

int difference = maxNumber(array) - minNumber(array);
Console.WriteLine($"Максимальный элемент массива: {maxNumber(array)}");
Console.WriteLine($"Минимальный элемент массива: {minNumber(array)}");
Console.WriteLine($"Разница между максимальным ({maxNumber(array)}) и минимальным ({minNumber(array)}) элементами массива = {difference}.");

int[] CreateArray(int size) 
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random ().Next(1,100);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
         System.Console.Write($"{number } ");
    }
    Console.WriteLine();
}

int maxNumber(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
    }
    return max;   
}

int minNumber(int[] numbers)
{
    int min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];
    }
   
    return min;
}

