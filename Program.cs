/* 
Задача 19 
 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
14212 -> нет 
12821 -> да 
23432 -> да 
*/ 
 
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int UserNumber = int.Parse(Console.ReadLine());
int ReverseNumber = 0;
int modifiedUserNumber = UserNumber;

if (UserNumber > 10000 && UserNumber < 99999)
{
    while (modifiedUserNumber > 0)
    {
        ReverseNumber = (ReverseNumber * 10) + (modifiedUserNumber % 10);
        modifiedUserNumber = modifiedUserNumber / 10;
    }

    if (ReverseNumber == UserNumber)
    {
        Console.WriteLine($"число {UserNumber} является полиндромом");
    }
    else
    {
        Console.WriteLine($"число {UserNumber} не является полиндромом");
    }
}
else
{
    Console.WriteLine($"число {UserNumber} не является пятизначным");
}
