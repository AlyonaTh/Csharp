System.Console.WriteLine("Введите число");
int number1= ReadInt();

if(number1%7 ==0 && number1%23 ==0)
{
    System.Console.WriteLine("Кратно 7 и 23");
}
else
{
    System.Console.WriteLine("Некратно");
}

int ReadInt()
{
    return int.Parse(Console.ReadLine());
}