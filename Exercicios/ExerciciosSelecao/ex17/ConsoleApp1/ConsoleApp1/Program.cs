

double l1, l2, l3;
Console.WriteLine("Informe o tamanho dos lados do triângulo: ");
l1 = double.Parse(Console.ReadLine());
l2 = double.Parse(Console.ReadLine());
l3 = double.Parse(Console.ReadLine());

if (l1 + l2 >= l3 && l3 + l1 >= l2 && l2 + l3 >= l1)
{
    if (l1 == l2 && l2 == l3)
    {
        Console.WriteLine("Triângulo equilátero");
    }
    else if (l1 == l2 || l2 == l3 || l1 == l3)
    {

        Console.WriteLine("Triângulo isoceles");
    }
    else
    {
        Console.WriteLine("Triângulo escaleno");
    }
}
else
{
    Console.WriteLine("Não é um trîângulo");
}


