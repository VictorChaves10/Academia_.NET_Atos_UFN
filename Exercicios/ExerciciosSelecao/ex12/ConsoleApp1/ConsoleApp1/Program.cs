

int codig;
double salary = 0.00, extra =00.00;

Console.Write("Enter your code: ");
codig = int.Parse(Console.ReadLine());

Console.Write("How many hours you worked: ");
string[] numberHours = Console.ReadLine().Split(":");

int hours = int.Parse(numberHours[0]);
int minutes = int.Parse(numberHours[1]);

salary = (hours * 10.00)+(minutes * 0.17);

if(hours >= 50 && minutes > 0)
{
    extra = ((hours - 50) * 20.00) + (minutes * 0.34);
    salary += extra;
    
}

Console.WriteLine($"Código: {codig}, salário total: R$ {salary.ToString("F2")}, salário extra: R$ {extra.ToString("F2")}");
