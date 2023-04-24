// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double ReadInt(string msg)
{
    System.Console.Write(msg);
    return double.Parse(Console.ReadLine());
} 
double x1 = ReadInt("Введите Х1: ");
double y1 = ReadInt("Введите У1: ");
double x2 = ReadInt("Введите Х2: ");
double y2 = ReadInt("Введите У2: ");

void lengthOT(double x1, double x2, double y1, double y2)
{
    System.Console.WriteLine("Длина отрезка равна "+ Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)));
}
lengthOT(x1,x2,y1,y2);