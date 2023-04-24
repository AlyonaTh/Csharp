// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}
int sumA(int a)
{
   int sum = 0;
for (int i = 0; i < a+1; i++)
{
    sum += i;
}
return sum;
}

int n = ReadInt("Введите число: ");
System.Console.WriteLine("Result "+ sumA(n));