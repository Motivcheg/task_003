//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] randomArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        randomArray[i] = new Random().Next(minValue, maxValue);
    }
    return randomArray;
}
int[] array = GetArray(5, 1, 9);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}| ");
    }
    Console.WriteLine("");
}
PrintArray(array);

int SumNotEven (int notEvenPos, int result)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            continue;
        }
        notEvenPos = array[i];
        result = result + notEvenPos;
    }
    return result;
}
int sumNotEven = SumNotEven(0, 0);
Console.WriteLine($"Сумма всех нечётных элементов равна: |{sumNotEven}|");