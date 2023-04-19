System.Console.WriteLine("Введите 1 число");
int number1= ReadInt();
System.Console.WriteLine("Введите 2 число");
int number2= ReadInt();
System.Console.WriteLine(squareN(number1,number2));

string squareN(int a, int b)
{
    if(a==Math.Pow(b,2))
{
    return "Да";
}
else if(b==Math.Pow(a,2))
{
    return "Да";
}
else{
    return "Нет";
}
}


int ReadInt()
{
    return int.Parse(Console.ReadLine());
} 