// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(int.Parse(Console.ReadLine()));
}
int valueDigits(int n)
{
    int result = 0;
    do
    {
      n/=10;
      result++;
    } while (n>0);
    return result;
}
int n = ReadInt("Введите число: ");
System.Console.WriteLine("Result "+ valueDigits(n));