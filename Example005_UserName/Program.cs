Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет дорогая Мария!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}