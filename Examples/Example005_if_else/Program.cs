Console.WriteLine("Введите Ваше имя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же МАШКА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
