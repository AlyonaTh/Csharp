Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() =="masha")
{
    Console.WriteLine("Uhuu, this is MASHA!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}