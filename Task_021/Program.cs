// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите aX: ");
int aX = int.Parse(Console.ReadLine());
Console.Write("Введите aY: ");
int aY = int.Parse(Console.ReadLine());
Console.Write("Введите aZ: ");
int aZ = int.Parse(Console.ReadLine());

Console.Write("Введите bX: ");
int bX = int.Parse(Console.ReadLine());
Console.Write("Введите bY: ");
int bY = int.Parse(Console.ReadLine());
Console.Write("Введите bZ: ");
int bZ = int.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2) + Math.Pow((bZ - aZ), 2));
Console.Write($"Расстояние между точками равно = {dist:f2}");