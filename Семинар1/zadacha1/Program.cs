Console.Write("Введите первое число: ");
double a = double.Parse( Console.ReadLine());
Console.Write("Введите второе число: ");
double b = double.Parse( Console.ReadLine());

Console.Write("Является ли первое число квадратом второго: ");
if(a == Math.Pow(b,2))
{
Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
