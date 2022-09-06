// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] ThreeDigitNumbersArray(int size = 5)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(100, 1000);
    }

    return array;
}
// foreach (var item in ThreeDigitNumbersArray(10)){ //строчки, чтобы проверить заполнение массива
// Console.WriteLine(item);
// }

int FindAmount(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
{
    count ++;
}
    }

    return count;
}
int[] array = ThreeDigitNumbersArray();
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(FindAmount(array));