

//Escreva um algoritmo para calcular o fatorial de um número.


Console.Write("Informe qual número deseja saber os fatorias: ");
int n = int.Parse(Console.ReadLine());

if (n != 0)
{
    for (int i = n - 1; i != 0; i--)
    {
        n = n * i;

    }

    Console.WriteLine(n);
}
else
{
    Console.WriteLine('1');
}

