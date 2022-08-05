// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter user name");
string username = Console.ReadLine();

if (username.ToLower() == "маша")

{
Console.WriteLine("Cool, it's Маша!");
}

else 

{
Console.WriteLine("Hello, ");
Console.Write(username);
}