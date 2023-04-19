
//int number = new Random().Next(10,100);
//Console.WriteLine("Случайное число " + number);
//int first = number/10;
//int second = number%10;
//if(first>second)
//{
//    Console.WriteLine("Первое больше " +first);
//}
//else{
//    Console.WriteLine("Второе больше "+ second);
//}
System.Console.Write("min ");
int min = ReadInt();
System.Console.Write("max ");
int max = ReadInt();
int number = GetRandomNumber(min, max);
System.Console.WriteLine(number);
if(GetFirstDigit(number)> GetSecondDigit(number))
{
    System.Console.WriteLine("First");
}
else
{
    System.Console.WriteLine("Second");
}


int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max+1);
}

int GetFirstDigit(int num)
{
    return num/10;
}
int GetSecondDigit(int num)
{
    return num%10;
}
int ReadInt()
{
    return int.Parse(Console.ReadLine());
}