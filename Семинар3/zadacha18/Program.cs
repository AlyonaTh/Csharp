// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return int.Parse(Console.ReadLine());
// } 
// int x = ReadInt("Введите номер четверти: ");


// string CheckD(int x)
// {
//     if(x==1)
//     {return "Х принадлежит от 0 до плюс бесконечности Y принадлежит от 0 до + бесконечности";}
//     else if(x==2)
//     {return "Х принадлежит от -бесконечности до 0 Y принадлежит от 0 до + бесконечности";}
//     else if(x==3)
//     {return "Х принадлежит от -бесконечности до 0 Y принадлежит от -бесконечности до 0 ";}
//     else if(x==4)
//     {return "Х принадлежит от 0 до плюс бесконечности Y принадлежит от -бесконечности до 0 ";}
//     else
//     return "Нет такой четверти";

// } 

// System.Console.WriteLine(CheckD(x));

System.Console.WriteLine("Укажите четверть");
int x = int.Parse(System.Console.ReadLine());

void WichSquare(int a)
{
switch (a)
{
case 1: System.Console.WriteLine("x > 0, y > 0"); break;
case 2: System.Console.WriteLine("x > 0, y < 0"); break;
case 3: System.Console.WriteLine("x < 0, y > 0"); break;
case 4: System.Console.WriteLine("x < 0, y < 0"); break;
default: System.Console.WriteLine("x = 0, и/или y = 0"); break;
}
}

WichSquare(x);