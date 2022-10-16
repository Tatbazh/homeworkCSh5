// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов
// массива.
// [3 7 22 2 78] -> 76
double[] RandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int index = 0; index < size; index++)
    {
        result[index] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

double DifferenceNumbers(double[] newArray)
{
    double max = newArray[0];
    double min = newArray[0];
    for (int index = 0; index < newArray.Length; index++)
    {
        if (newArray[index] > max) max = newArray[index];
        if (newArray[index] < min) min = newArray[index];
    }
    double diff = max - min;
    return diff;
}

double[] arrayRand = RandomArray(5, 1, 10);
Console.WriteLine($"массив: {String.Join(" ", arrayRand)}");

double diffNumb = DifferenceNumbers(arrayRand);
Console.WriteLine($"разница между max и min элементами: {diffNumb}");