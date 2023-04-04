



int day, month, year;

Console.Write("Digite a data atual (DD/MM/AAAA): ");

string[] date = Console.ReadLine().Split('/');

day = int.Parse(date[0]);
month = int.Parse(date[1]);
year = int.Parse(date[2]);

Console.WriteLine($"\n {year}/{month.ToString("D2")}/{day.ToString("D2")}");

Console.WriteLine($"\n {year-2000}/{month.ToString("D2")}/{day.ToString("D2")}");


