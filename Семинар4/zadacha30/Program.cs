// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(int.Parse(Console.ReadLine()));
}
int[] randomArray(int a)
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++)
    {
        result[i]= new Random().Next(0,2);
    }
    return result;
}

int n = ReadInt("Введите число: ");
System.Console.WriteLine("Result " + String.Join(", ",randomArray(n)));
