// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(int.Parse(Console.ReadLine()));
}
int multiplicationA(int a)
{
    int result = 1;
    for (int i = 1; i <= a; i++)
    {
        result *= i;
    }
    return result;
}

int n = ReadInt("Введите число: ");
System.Console.WriteLine("Result " + multiplicationA(n));
