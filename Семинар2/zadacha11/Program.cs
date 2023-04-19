System.Console.WriteLine("Введите трехзначное число: ");
int number = ReadInt();
if (number>99 && number<1000)
{
    System.Console.WriteLine(""+GetFirstDigit(number)+GetThirdDigit(number));
}
else
{
    System.Console.WriteLine("Error");
}
int GetFirstDigit(int num)
{
    return num/100;
}
int GetSecondDigit(int num)
{
    return num/10;
}
int GetThirdDigit(int num)
{
    return num%10;
}
int ReadInt()
{
    return int.Parse(Console.ReadLine());
}
// string RemoveSecondDigit(int number)
// {
//     return Convert.ToString(GetFirstDigit(number)) + Convert.ToString(GetThirdDigit(number));
// }