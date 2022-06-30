// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//int n = 12321;
// int a = n/10000;     первая цифра
// int b = n/1000%10;   вторая цифра
// int c = n/10%10;     четвертая цифра
// int d = n%10;        пятая цифра

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Palindrome(n);

void Palindrome(int n)
{
    if (n/10000 == n%10 && n/1000%10 == n/10%10)
    {
        Console.WriteLine("Введенное число является палиндромом.");
    }
    else if (n > 100000 | n < 10000)
    {
        Console.WriteLine("Введенное число не является пятизначным.");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом.");
    }
}
