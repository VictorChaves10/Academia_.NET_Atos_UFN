// Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.


int[,] matA = new int[4, 4];
int[,] matB = new int[4, 4];

Random valueMat = new Random();

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matA[j, i] = valueMat.Next(0, 20);
        matB[j, i] = valueMat.Next(0, 20);

    }
}

Console.WriteLine("\nMatriz A\n");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matA[i, j].ToString("D2")}\t");
    }

    Console.WriteLine();
}

Console.WriteLine("\nMatriz B\n");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matB[i, j].ToString("D2")}\t");
    }

    Console.WriteLine();
}

Console.WriteLine("\nSoma das Matrizes A e B\n");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        int soma = matB[i, j] + matA[i, j];
        Console.Write($"{soma.ToString("D2")}\t");
    }

    Console.WriteLine();
}