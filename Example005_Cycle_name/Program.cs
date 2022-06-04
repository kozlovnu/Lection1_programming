Console.Write("Enter user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "nikita") // .ToLower() делает текст нечувствительным к регистру
{
    Console.WriteLine("Hello, my dear friend, Nick!");
}
else
{
    Console.Write("Hi, bustard ");
    Console.WriteLine(username);
}
