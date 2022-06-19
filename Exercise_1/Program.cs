// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом


string Prompt (string message)
{
    System.Console.WriteLine(message);
    string num = Console.ReadLine();
    return num;
}
string num = Prompt("Введите пятизначное число ");

if (num.Length != 5)
{
    Console.WriteLine($"{num} - данное число не пятизначное");
}
else
{
    if (num[0] == num[4] && num[1]  == num[3] ) 
    {
        Console.WriteLine($"{num} - палиндром");
    }
    else
    {
        Console.WriteLine($"{num} не палиндром");
    }
}
