void FillArray(int[] numbers, int minValue = -10, int maxValue = 10)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue,maxValue);
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
void Reverse(int[] numbers)
{
    int halfSize = numbers.Length/2;
    int lastIndex = numbers.Length - 1;
    for (int i = 0; i < halfSize; i++)
    {
        int temp = numbers[i];
        numbers[i] = numbers[lastIndex - i];
        numbers[lastIndex - i]= temp;
    }
}
void SizeCheck(int sideA, int sideB, int sideC)
{
    if (sideA<(sideB+sideC) && sideB<(sideA + sideC) && sideC < (sideA+ sideB))
    {
        Console.WriteLine("Треугольник существует");
    }
    else Console.WriteLine("Треугольника не существует");
}
string Input(string text)
{
    System.Console.Write($"{text} ");
    return Console.ReadLine();
}
void DecToBin(int decNum)
{
    int resultInt = 0;
string resultStr = "";
int shift = 1;
  while (decNum>0)
  {
    resultStr = decNum%2 + resultStr;
    resultInt += decNum%2*shift;
    shift *= 10;
    decNum/=2;
  }  
  Console.WriteLine($"Результат строковый: {resultStr}");
    Console.WriteLine($"Результат числовой: {resultInt}");
}
// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
void zadacha39()
{
System.Console.WriteLine("Введите размер массива: ");
int size= Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("Массив:");
PrintArray(numbers);
Reverse(numbers);
Console.WriteLine("Перевернутый массив:");
PrintArray(numbers);
}
// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со
// сторонами такой длины.
void zadacha40()
{
    int numberA = Convert.ToInt32(Input("Введите число А: "));
    int numberB = Convert.ToInt32(Input("Введите число B: "));
    int numberC = Convert.ToInt32(Input("Введите число C: "));
    SizeCheck(numberA,numberB,numberC);
}
// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
void zadacha42()
{
int numberDec = Convert.ToInt32(Input("Введите число:"));
DecToBin(numberDec);
}
// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
void zadacha44()
{
  int count = Convert.ToInt32(Input("Количество элементов последовательности:"));  
  int numF = 0;
  int numS = 1;
for (int i = 0; i < count; i++)
{
    Console.Write($"{numF} ");
    (numF, numS) = (numS, numF + numS);
    // int temp = numF;
    // numF = numS;
    // numS = temp + numS;
}
}
zadacha44();
