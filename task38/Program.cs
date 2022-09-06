// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// найти индекс минимального и индекс максимального числа
// максимум минус минимум?

int size = new Random().Next(5, 5);

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void MinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    int diff = arr.Max() - arr.Min();
    System.Console.WriteLine($"Минимальное значение {arr.Min()}, максимальное значение {arr.Max()}");
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями = {diff}");
    System.Console.WriteLine();
}

MinMax(Array(size));