Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower()  == "иван")
{
    Console.WriteLine("Ура, это же Иван!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}