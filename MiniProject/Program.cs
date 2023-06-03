// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter your name: ");
var name = Console.ReadLine();
Console.Write("Enter your age: ");
var age = int.Parse(Console.ReadLine());

if (name == "Bob" || name == "Sue")
{
    Console.WriteLine($"Hello Professor {name}");
}
else if (age < 21)
{
    var needYears = 21 - age;
    Console.WriteLine($"You should wait {needYears} more years");
}
else
{
    Console.WriteLine("Welcome!");
}