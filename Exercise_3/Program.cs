// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int Number = Prompt("Введите число ");
int count = 1;
while (count < Number)
{
    System.Console.WriteLine(count * count * count);
    count++;
};