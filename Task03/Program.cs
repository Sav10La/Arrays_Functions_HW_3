// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число больше 0: ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);

void Cube(int n)
{
    if (n > 0)
    {
        int i = 1;
        while (i <= n)
        {
            double cube = Math.Pow(i,3);
            i++;
            Console.WriteLine(cube);
        }
    }
    else
    {
        Console.WriteLine("Введите число больше 0!");
    }
}