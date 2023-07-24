using System.Globalization;

DateTime today = DateTime.UtcNow;

DateTime birthDate = DateTime.Parse("11/12/2000");
birthDate = DateTime.ParseExact("12/11/2000", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(today.ToString("MMMM d, yyyy hh:mm tt zzz"));