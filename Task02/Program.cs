// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int z2 = Convert.ToInt32(Console.ReadLine());



Distance(x1, y1, x2, y2);

void Distance(int x1, int y1, int x2, int y2)
{
    double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    Console.WriteLine(d);
}