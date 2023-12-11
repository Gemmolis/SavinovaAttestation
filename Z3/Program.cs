// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] originalArray = {1, 2, 5, 0, 10, 34}; 

Console.Write("Исходный массив: ");
foreach (int number in originalArray)
{
Console.Write(number + " ");
}
void PrintBacknumbers(int[] originalArray, int i)
{

    Console.Write(originalArray[i] + " ");
    if(i > 0)
    PrintBacknumbers(originalArray, i - 1);
    return;

}
Console.Write("\nПеревернутый массив: ");
PrintBacknumbers(originalArray, originalArray.Length - 1);
  