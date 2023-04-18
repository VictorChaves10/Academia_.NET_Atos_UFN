//14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
//são os mesmos da diagonal secundária (direita pra esquerda).

int[,] mat = new int[5, 5];
Random valueMat = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        mat[j, i] = valueMat.Next(0, 20);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{mat[j, i].ToString("D2")}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
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
            Console.WriteLine($"\t\t\t\t{mat[i, x].ToString("D2")}");
            break;
        case 3:
            Console.WriteLine($"\t\t\t{mat[i, x].ToString("D2")}");
            break;
        case 2:
            Console.WriteLine($"\t\t{mat[i, x].ToString("D2")}");
            break;
        case 1:
            Console.WriteLine($"\t{mat[i, x].ToString("D2")}");
            break;
        case 0:
            Console.WriteLine($"{mat[i, x].ToString("D2")}");
            break;
    }

    x++;
}

Console.WriteLine();
int y = 4;
for (int i = 0; i < 5; i++)
{

    if (mat[i, i] == mat[i, y])
    {
        Console.WriteLine($"Na posição [{i + 1}, {i + 1}] existe um mesmo número na posição [{i + 1}, {y + 1}]");
    }

    y--;
}

