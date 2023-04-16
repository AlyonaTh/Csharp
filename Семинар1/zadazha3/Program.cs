Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Число соотносится с ");
if( a==1)
{
    Console.WriteLine("Понедельником");
}
else if( a==2)
{
    Console.WriteLine("Вторником");
}
else if( a==3)
{
    Console.WriteLine("Средой");
}
else if( a==4)
{
    Console.WriteLine("Четвергом");
}
else if( a==5)
{
    Console.WriteLine("Пятницей");
}
else if( a==6)
{
    Console.WriteLine("Субботой");
}
else if( a==7)
{
    Console.WriteLine("Воскресеньем");
}
else
{
 Console.WriteLine("Ерундой");
}