int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    Random rnd = new Random();
    int[,] array = new int[firstLength,secondLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 10);
        }
    }
    return array;
}
double[,] CreateSquareArray(int firstLength, int secondLength)
{
    double q = 0;
    double[,] array = new double[firstLength,secondLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Pow(q,2);
            q++;
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
     for (int j = 0; j < array.GetLength(1); j++)
        {
           if (j==i)
           {
            Console.ForegroundColor = ConsoleColor.Green;
           }
           else
           {
            Console.ForegroundColor = ConsoleColor.White;
           }
            Console.Write($"{array[i,j]} " );
        }   
        Console.WriteLine();
    }
}
void PrintArray1(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
     for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} " );
        }   
        Console.WriteLine();
    }
}
void FillmnArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
     for (int j = 0; j < array.GetLength(1); j++)
        {
             array[i,j] = i+j;
        }   
    }
}
string Input(string text)
{
    System.Console.Write($"{text} ");
    return Console.ReadLine();
}
void zadacha48()
{
    int m = Convert.ToInt32(Input("Введите число m: "));
    int n = Convert.ToInt32(Input("Введите число n: "));
    int[,] array = new int[m,n];
    FillmnArray(array);
    PrintArray(array);
}
void zadacha49()
{
    int m = Convert.ToInt32(Input("Введите число m: "));
    int n = Convert.ToInt32(Input("Введите число n: "));
    int[,] array = new int[m,n];
    array = CreateTwoDimensionArray(m,n);
    PrintArray(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
        }
    }
    PrintArray(array);
}

void zadacha51()
{
    int m = Convert.ToInt32(Input("Введите число m: "));
    int n = Convert.ToInt32(Input("Введите число n: "));
    int[,] array = new int[m,n];
    array = CreateTwoDimensionArray(m,n);
    PrintArray(array);
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==j)
            {
               sum += array[i,j] ;
            }
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
}
zadacha51();