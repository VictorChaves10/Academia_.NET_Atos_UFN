//Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

double[,] mat = new double[3, 3];

for(int i = 0; i < 3; i++)
{
    for(int j =0; j < 3; j++)
    {
        Console.Write($"Digite o valor da coluna {i+1} linha {j+1}: ");
        mat[j,i] = double.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{mat[j,i]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    double div = 0.00;

    for (int j = 0; j < 3; j++)
    {
        div = mat[i, j] / (i + j);
        Console.Write($"{div.ToString("F2")}\t");
    }
    Console.WriteLine();
}