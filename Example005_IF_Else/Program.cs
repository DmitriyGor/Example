Console.Write("Введите имя пользователя  ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, этоже МаШа !!!");
}
else
{
    Console.Write("Ой, это просто  ");
    Console.WriteLine(username);
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

