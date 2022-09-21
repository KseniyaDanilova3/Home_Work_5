// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int Size = 5;
int[] array = CreateArray(Size);
PrintArray(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {OddPosition(array)}.");

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
    foreach (int number in numbers)
    {
         System.Console.Write($"{number } ");
    }
    Console.WriteLine();
}

int OddPosition(int[] numbers)
{
    int OddPositionSum = 0;
    for (int i = 0; i < numbers.Length; i +=2)
    {
            OddPositionSum += numbers[i];
    }
    return OddPositionSum;
}
