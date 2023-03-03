// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Enter your firstname");
var name = Console.ReadLine();
Console.WriteLine("Enter your lastname");
var lastname = Console.ReadLine();
Console.WriteLine($"my name is {name} and my lastname is {lastname}");
Console.ReadLine();
