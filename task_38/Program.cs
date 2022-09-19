//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 10;
    Console.WriteLine($"|{Math.Round(array[i], 2)}|");

}

double findMax(double maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (maxValue < array[i])
        {
            maxValue = array[i];
        }
    }
    Console.WriteLine($"[Максимальный элемент] = |{Math.Round(maxValue, 2)}|");
    return maxValue;
}

double findMin(double minValue)
{
    int i = 0;
    while(array.Length > i)
    {
        if(array[i] < minValue)
        {
            minValue = array[i];
        }
        i++;
    }
    Console.WriteLine($"[Минимальный элемент] = |{Math.Round(minValue, 2)}|");
    return minValue;
    
}
double maxElement = findMax(0);
double minElement = findMin(array[0]);


Console.WriteLine($"[Разница минимального от максимального] = |{Math.Round(maxElement , 2) - Math.Round(minElement , 2) }|");

