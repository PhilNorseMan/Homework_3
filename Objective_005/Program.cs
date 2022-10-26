/*Задача 19 - HARD необязательная

Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.*/

void PalindromeTest(string? num)
{
    char[] arr;

    arr = num!.ToCharArray();
    
    if(arr.Length % 2 == 0)
    {
        int frontCountEven = 0;
        int rearCountEven = arr.Length - 1;
        int centreEven = arr.Length / 2;
        int falseEven = 0;
   
        while(frontCountEven <= centreEven && rearCountEven >= centreEven)
        {
            if(arr[frontCountEven] == arr[rearCountEven]) 
            {
                
            }
            else
            {
                falseEven = 1;
            }       
            frontCountEven = frontCountEven+1;
            rearCountEven = rearCountEven-1;      
        }
        if(falseEven == 1)
        {
            Console.WriteLine("No, number " + num + " isn't a palindrome");
        }
        else
            Console.WriteLine("Yes, number " + num + " is a palindrome");
    }
    else
    {
        int frontCountOdd = 0;
        int rearCountOdd = arr.Length - 1;
        int centreOdd = arr.Length / 2;
        int falseOdd = 0;
   
        while(frontCountOdd < centreOdd && rearCountOdd > centreOdd)
        {
            if(arr[frontCountOdd] == arr[rearCountOdd]) 
            {
                
            }
            else
            {
                falseOdd = 1;
            }       
            frontCountOdd = frontCountOdd+1;
            rearCountOdd = rearCountOdd-1;      
        }
        if(falseOdd == 1)
        {
            Console.WriteLine("No, number " + num + " isn't a palindrome");
        }
        else
            Console.WriteLine("Yes, number " + num + " is a palindrome");
    }


       
}

Console.WriteLine("Input number: ");
string? num = Console.ReadLine();

PalindromeTest(num);