// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.

double ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return double.Parse(Console.ReadLine());
} 
double x = ReadInt("Введите Х: ");
double y = ReadInt("Введите У: ");

string CheckCh(double x, double y)
{
    if(x> 0 && y>0)
    {return "1 четверть";}
    else if(x< 0 && y>0)
    {return "2 четверть";}
    else if(x< 0 && y<0)
    {return "3 четверть";}
    else if(x> 0 && y<0)
    {return "4 четверть";}
    else
    return "Вне четвертей";

} 

System.Console.WriteLine(CheckCh(x,y));