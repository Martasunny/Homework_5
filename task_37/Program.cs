// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


Console.WriteLine($"Enter lenght of array...\t");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(1, 10);
}
Console.WriteLine($"You array: {String.Join(", ", array)}");
int mid = number / 2;
int remainder = number % 2;
int array2Length = 0;
if (remainder == 0) {
    array2Length = mid;
} else {
    array2Length = mid + 1;
}
int [] array2 = new int[array2Length];
int min = 0;
int max = number - 1;
int result = 0;
while (min != mid)
{
    result = array[min] * array[max];
    array2[min] = result;
    min = min + 1; 
    max = max - 1;
}
if (remainder != 0) {
    array2[min] = array[min];
}
Console.WriteLine($"Your result: {String.Join(", ", array2)}");