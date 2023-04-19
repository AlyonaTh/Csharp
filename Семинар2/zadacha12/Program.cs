System.Console.WriteLine("Введите первое число");
int number1= ReadInt();
System.Console.WriteLine("Введите второе число");
int number2 = ReadInt();

if(number1%number2 ==0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Некратно, остаток: " + number1%number2);
}

int ReadInt()
{
    return int.Parse(Console.ReadLine());
}