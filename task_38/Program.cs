// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}
Console.WriteLine(string.Join(", ", array));

int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) 
    {
        min = array[i];  
    } 
    if (array[i] > max) 
    {
        max = array[i];  
    } 
}
Console.WriteLine($"min: {min} max: {max}");
int result = max - min;
Console.WriteLine($"result: {result}");