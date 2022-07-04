Console.Write("Enter username");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Hello, stranger");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
