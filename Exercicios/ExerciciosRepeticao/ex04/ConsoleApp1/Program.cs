//Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.

int x, y, potencia, n;

Console.Write("Informe o valor de x: ");
x = int.Parse(Console.ReadLine());

Console.Write("Informe o valor de y: ");
y = int.Parse(Console.ReadLine());

if (x > 1)
{
    n = x * x;

    for (int i = 2; i < y; i++)
    {

        potencia = n * x;
        n = potencia;

    }

    Console.WriteLine(n);
    Console.WriteLine(Math.Pow(x, y));
}
else
{
    Console.WriteLine(x);
}