/*Задача 21 - HARD необязательная

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.*/

double DistanceCount2D(int[] coordinates_a, int[] coordinates_b)
{
    return Math.Sqrt(Math.Pow(coordinates_b[0] - coordinates_a[0], 2) + Math.Pow(coordinates_b[1] - coordinates_a[1], 2));
}

double DistanceCount3D(int[] coordinates_a, int[] coordinates_b)
{
    return Math.Sqrt(Math.Pow(coordinates_b[0] - coordinates_a[0], 2) + Math.Pow(coordinates_b[1] - coordinates_a[1], 2) + Math.Pow(coordinates_b[2] - coordinates_a[2], 2));
}



Console.WriteLine("Please, set the dimension of space as a number: ");
int dimension = int.Parse(Console.ReadLine()!);

if (dimension == 2)
{
    int[] coordinates_a = new int[2];
    int[] coordinates_b = new int[2];

    Console.WriteLine("Set coordinates for point A");
    Console.WriteLine("Set coordinate xA:");
    coordinates_a[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Set coordinate yA:");
    coordinates_a[1] = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Set coordinates for point B");
    Console.WriteLine("Set coordinate xB:");
    coordinates_b[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Set coordinate yB:");
    coordinates_b[1] = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Distace between A and B = ");
    Console.WriteLine(Math.Round(DistanceCount2D(coordinates_a, coordinates_b), 3));
}

if (dimension == 3)
{
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
    Console.WriteLine(Math.Round(DistanceCount3D(coordinates_a, coordinates_b), 2));
}

if(dimension == 1)
{
    Console.WriteLine("O-o-o-kay, set coordinate for point A");
    int coordA = int.Parse(Console.ReadLine()!);
    Console.WriteLine("O-o-o-kay, now set coordinate for point B:");
    int coordB = int.Parse(Console.ReadLine()!);

    int res = coordB - coordA;
    if (res < 0) res = res * -1;
    Console.WriteLine("Okay, here you are: " + coordB + " <-> " + coordA + " = " + res);
    Console.WriteLine("Are you satisfied? =)");
}
if (dimension > 3)
{
    Console.WriteLine("Sorry, you collapsed the universe =(");
}