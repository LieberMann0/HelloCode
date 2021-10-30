Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Здравствуйте, уважаемая Маша!");
}
else
{
    Console.Write("Досвидания, ");
    Console.Write(username);
}