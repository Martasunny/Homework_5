//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



int[] RandomArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}
void SumNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
           result = result + array[i];
        }
    } 
    Console.WriteLine("Cуммa элементов, стоящих на нечётных позициях:\t" +result);
}
SumNumbers(RandomArray());
