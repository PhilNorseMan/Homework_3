/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Set number: ");
int num = int.Parse(Console.ReadLine()!);

int QubeNum(int num)
{
    int qube_num = num*num*num;
    return qube_num;
}

int[] arr = new int[num];

while(num > 0)
{
    arr[num - 1] = QubeNum(num);
    num = num - 1;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    num = num + 1;

    for(int i = 0; i < count; i++)
    {
        Console.WriteLine(num + " ^ 3 = " + arr[i]);
        num++;
    }
    Console.WriteLine();
}

PrintArray(arr);