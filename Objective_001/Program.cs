/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

14212 -> нет

12821 -> да

23432 -> да*/

void PalindromeTestFiveDigit(string? num)
{
    char[] arr;

    arr = num!.ToCharArray();
    
    int frontCount = 0;
    int rearCount = arr.Length - 1;
    int centre = 2;
    int result = 0;

    if(arr.Length > 5 || arr.Length < 5)
    {
        Console.WriteLine(num + " is not five-digit!!!");
    }
    else
    {
        while(frontCount < centre)
        {
            if(arr[frontCount] == arr[rearCount]) 
            {
                result = 1;
            }
            else
            {
                result = 0;
            }       
        frontCount = frontCount+1;
        rearCount = rearCount-1;      
        }
        if(result == 0)
        {
            Console.WriteLine("No, number " + num + " isn't a palindrome");
        }
        else
            Console.WriteLine("Yes, number " + num + " is a palindrome");
    }   
}

Console.WriteLine("Input number: ");
string? num = Console.ReadLine();

PalindromeTestFiveDigit(num);