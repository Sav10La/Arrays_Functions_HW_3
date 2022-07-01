// Дополнительные задачи.
//Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.

Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Divide(n);

void Divide(int n)
{
    if (n % 3==0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
}