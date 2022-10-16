// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int index = 0; index < size; index++)
    {
        result[index] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int EvenNumbers(int[] newArray)
{
    int count = 0;
    foreach (int element in newArray)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arrayR = RandomArray(4, 100, 999);
Console.WriteLine(String.Join(" ", arrayR));

//Console.Write(EvenNumbers(arrayR));
Console.Write($"количество четных чисел в массиве = {EvenNumbers(arrayR)}");