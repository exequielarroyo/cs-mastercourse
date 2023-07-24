Console.WriteLine("Your age:");

int? age = int.Parse(Console.ReadLine());

Console.WriteLine($"In 25 years you are {age + 25}");

Console.WriteLine($"25 years ago you are {age - 25}");