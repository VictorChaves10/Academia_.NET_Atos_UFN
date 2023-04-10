

double n1, n2, n3;

Console.WriteLine("Informe os valores:");
n1 = double.Parse(Console.ReadLine());
n2 = double.Parse(Console.ReadLine());
n3 = double.Parse(Console.ReadLine());


if(n1 > n2)
{
    Console.WriteLine($"O {n1} é o maior!");
}
else if (n2 > n3)
{
    Console.WriteLine($"O {n1} é o maior!");
}
else if(n3 > n1 && n3 > n2)
{

    Console.WriteLine($"O {n3} é o maior!");
}
