// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

const int Size = 5;
int[] array = CreateArray(Size);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве = {EvenNumbers(array)}.");

int[] CreateArray(int size) 
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random ().Next(100,1000);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i] } ");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] numbers)
{
    int EvenNumbersSum = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
            EvenNumbersSum++;
    }
    return EvenNumbersSum;
}