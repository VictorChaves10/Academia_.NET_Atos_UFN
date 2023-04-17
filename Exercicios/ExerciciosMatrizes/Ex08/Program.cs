
// Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.



int[,] mat = new int[4, 4];
Random valueMat = new Random();

for(int i = 0; i< 4; i++)
{
    for (int j = 0; j < 4; j++) 
    {
        mat[j, i] = valueMat.Next(0, 20);
    }
}

Console.WriteLine("Matriz ordenada\n");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{mat[j, i]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nMatriz inversa\n");

for (int i = 3; i >= 0; i--)
{
    for (int j = 3; j >= 0; j--)
    {
        Console.Write($"{mat[j,i]}\t");
    }

    Console.WriteLine();
}

