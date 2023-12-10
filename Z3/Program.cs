// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] numbers = {1, 3, 5, 6, 7, 8}; 
int temp;

Console.Write("Исходный массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}


for (int i = 0; i < numbers.Length / 2; i++)
{
temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}
Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)

Console.Write(number + " ");

