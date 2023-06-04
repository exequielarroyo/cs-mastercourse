Console.Write("Enter your name: ");
var name = Console.ReadLine();
Console.Write("Enter your age: ");

if (!int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("You did not provide a valid age.");
    return;
}

string formatedName = name;

if (name == "Bob" || name == "Sue")
{
    formatedName = $"Profession {name}";
}

if (age < 21)
{
    Console.WriteLine($"I recommend you wait {21 - age} years, {formatedName}");
}
else
{
    Console.WriteLine($"Welcome to class {formatedName}");
}