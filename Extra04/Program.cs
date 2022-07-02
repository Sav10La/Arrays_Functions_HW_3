// Дополнительные задачи.
//Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    array[index] = 1;
    while (index < length)
    {
        Console.WriteLine(array[index]);
        index++;
        array[index] = index + 1;
    }
}
int[] array = new int [10];
PrintArray(array);