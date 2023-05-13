// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

void FillArray(int[] numbers, int minValue = -9, int maxValue = 10)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

int GetPositiveSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) sum += numbers[i];
    }
    return sum;
}
int GetNegativeSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) sum += numbers[i];
    }
    return sum;
}
void ChangeSign(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] *= -1;
    }
}

void CheckNumber(int[] numbers, int a)
{
    bool flag = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == a)
        {
            flag = true;
        }
    }
    if (flag) Console.WriteLine("Чило найдено");
    else Console.WriteLine("Такого числа нет");
}
int CountElementInSegment(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >=10 && numbers[i]<= 99 )
        {
            count++;
        }
    }
    return count;
}

void zadacha31()
{
    int size = 12;
    int[] numbers = new int[size];

    FillArray(numbers, -9, 10);
    PrintArray(numbers);
    Console.WriteLine($"Сумма положительных: {GetPositiveSum(numbers)}");
    Console.WriteLine($"Сумма отрицательных: {GetNegativeSum(numbers)}");
}

// Задача 32: Напишите программу замены элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
void zadacha32()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    ChangeSign(numbers);
    PrintArray(numbers);
}

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void zadacha33()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.Write("Введите число: ");
    int currentNumber = Convert.ToInt32(Console.ReadLine());
    CheckNumber(numbers, currentNumber);

}
// Задача 35: Задайте одномерный массив из 10 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 
void zadacha35()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers,0 ,120);
    PrintArray(numbers);
    int count = CountElementInSegment(numbers);
    Console.WriteLine($"Количество элементов в отрезке [10, 99] равно {count}");
}
zadacha35();