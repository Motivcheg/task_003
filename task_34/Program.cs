//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] GetArray(int length, int minValue, int maxValue)
{
    int[] randomArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        randomArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return randomArray;
}
int[] array = GetArray(20, 100, 1000);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}
PrintArray(array);

int fineEven(int j, int count)
{
    while (j < array.Length)
    {
        if (array[j] % 2 == 0)
        {
            count = count + 1;
        }
        j++;
    }
    return count;

}
int EvenCount = fineEven(0, 0);
Console.WriteLine(EvenCount);

