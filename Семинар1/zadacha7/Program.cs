Console.Write("Введите целое трехзначное число: ");
int a = int.Parse(Console.ReadLine());

if(a>99 && a < 1000)
{
    Console.WriteLine(a%10);
}
else
{
    Console.WriteLine("Ошибка");
}