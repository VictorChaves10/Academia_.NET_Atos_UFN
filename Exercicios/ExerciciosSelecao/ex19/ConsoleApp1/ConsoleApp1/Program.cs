



double n1, n2, n3;

Console.WriteLine("Informe os valores:");
n1 = double.Parse(Console.ReadLine());
n2 = double.Parse(Console.ReadLine());
n3 = double.Parse(Console.ReadLine());


if(n1 > n2 && n1 > n3)
{
    Console.WriteLine(n1);
    if(n2 > n3)
    {
        Console.WriteLine(n2);
        Console.WriteLine(n3);
    }
    else
    {
        Console.WriteLine(n3);
        Console.WriteLine(n2);
    }
}
else if (n2 > n3 && n2 > n1)
{
    Console.WriteLine(n2);
    if(n1 > n3)
    {
        Console.WriteLine(n1);
        Console.WriteLine(n3);
    }
    else
    {
        Console.WriteLine(n3);
        Console.WriteLine(n1);
    }
}
else
{
    Console.WriteLine(n3);
    if (n1 > n2)
    {
        Console.WriteLine(n1);
        Console.WriteLine(n2);
    }
}

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"\nO {n1} é o maior!");
}
else if (n2 > n3)
{
    Console.WriteLine($"\nO {n2} é o maior!");
}
else
{
    Console.WriteLine($"\nO {n3} é o maior!");
}