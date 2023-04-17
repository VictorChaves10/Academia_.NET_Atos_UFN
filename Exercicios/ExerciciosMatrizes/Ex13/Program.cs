//Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
//diagonal secundária.

using System.Diagnostics.Contracts;

int[,] mat = new int[5, 5];
Random valueMat = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        mat[i, j] = valueMat.Next(0, 20);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{mat[i, j].ToString("D2")}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nDiagonal principal\n");

for (int i = 0; i < 5; i++)
{
    switch (i)
    {
        case 0:
            Console.WriteLine($"{mat[i, i].ToString("D2")}");
            break;
        case 1:
            Console.WriteLine($"\t{mat[i, i].ToString("D2")}");
            break;
        case 2:
            Console.WriteLine($"\t\t{mat[i, i].ToString("D2")}");
            break;
        case 3:
            Console.WriteLine($"\t\t\t{mat[i, i].ToString("D2")}");
            break;
        case 4:
            Console.WriteLine($"\t\t\t\t{mat[i, i].ToString("D2")}");
            break;
    }
}

Console.WriteLine("\nDiagonal secundaria\n\n");

int x = 0;
for (int i = 4; i >= 0; --i)
{

    switch (i)
    {
        case 4:
            Console.WriteLine($"\t\t\t\t{mat[x, i].ToString("D2")}");
            break;
        case 3:
            Console.WriteLine($"\t\t\t{mat[x, i].ToString("D2")}");
            break;
        case 2:
            Console.WriteLine($"\t\t{mat[x, i].ToString("D2")}");
            break;
        case 1:
            Console.WriteLine($"\t{mat[x, i].ToString("D2")}");
            break;
        case 0:
            Console.WriteLine($"{mat[x, i].ToString("D2")}");
            break;
    }

    x++;
}