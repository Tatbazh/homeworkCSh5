// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int index = 0; index < size; index++)
    {
        result[index] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int NoEvenIndex(int[] newArray)
{
    int sum = 0;
    for (int index = 0; index < newArray.Length; index++)
    {
        if (index % 2 != 0) sum = sum + newArray[index];
    }
    return sum;
}

int[] arrayRand = RandomArray(4, -10, 10); 
Console.WriteLine($"массив: {String.Join(" ", arrayRand)}");

int result = NoEvenIndex(arrayRand);
Console.WriteLine($"сумма элементов с нечетным индексом: {result}");