// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//сумму чисел нечетных индексов!!! само число может быть каким угодно и четным и нечетным и положительным и отрицательным !!!

int[] SumOddI(int size = 4)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(1, 100);
    }

    return array;
}

// foreach (var item in SumOddI(4)){ //строчки, чтобы проверить заполнение массива
// Console.WriteLine(item);
// }
int FindSumOddI(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
    {
    if (i % 2 > 0)
{
    sum = sum + array[i];
}
    }

    return sum;
}
int[] array = SumOddI();
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(FindSumOddI(array));