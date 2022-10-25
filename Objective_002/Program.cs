/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

double DistanceCount(int[] coordinates_a, int[] coordinates_b)
{
    return Math.Sqrt(Math.Pow(coordinates_b[0] - coordinates_a[0], 2) + Math.Pow(coordinates_b[1] - coordinates_a[1], 2) + Math.Pow(coordinates_b[2] - coordinates_a[2], 2));
}

int[] coordinates_a = new int[3];
int[] coordinates_b = new int[3];


Console.WriteLine("Set coordinates for point A");
Console.WriteLine("Set coordinate xA:");
coordinates_a[0] = int.Parse(Console.ReadLine()!);
Console.WriteLine("Set coordinate yA:");
coordinates_a[1] = int.Parse(Console.ReadLine()!);
Console.WriteLine("Set coordinate zA:");
coordinates_a[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Set coordinates for point B");
Console.WriteLine("Set coordinate xB:");
coordinates_b[0] = int.Parse(Console.ReadLine()!);
Console.WriteLine("Set coordinate yB:");
coordinates_b[1] = int.Parse(Console.ReadLine()!);
Console.WriteLine("Set coordinate zB:");
coordinates_b[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Distace between A and B = ");
Console.WriteLine(Math.Round(DistanceCount(coordinates_a, coordinates_b), 2));