



using System.ComponentModel.Design.Serialization;

double n1, n2, n3;



Console.WriteLine("informe três números: ");

n1 = double.Parse(Console.ReadLine());
n2 = double.Parse(Console.ReadLine());
n3 = double.Parse(Console.ReadLine());


if ((n2 + n3 > n1) && (n1 + n3 > n2) && (n1 + n2 > n3))
{
    if (n1 == n2 && n2 == n3)
    {
        Console.WriteLine("Triangulo equilátero");
    }
    else if(n1 == n2 || n2 == n3 || n3 == n1)
    {
        Console.WriteLine("Isóceles");
    }
    else
    {
        Console.WriteLine("escaleno");
    }
}

