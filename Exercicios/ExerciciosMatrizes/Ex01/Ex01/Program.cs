// Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.




int[,] mat = new int[5,3];




for (int j = 0; j < 5; j++)
{
    Console.Write($"Digite o valor da coluna {1} e da linha {j+1}: ");
    mat[j,0] = int.Parse(Console.ReadLine());
}

for (int i= 0; i < 5; i++)
{
    mat[i,1] = mat[i,0] + 10;
}

for (int i = 0; i < 5; i++)
{
    mat[i,2] = mat[i,0] * 2;
}

Console.WriteLine();
//imprimir os valores

for (int i = 0; i < 5; i++)
{
    for(int j= 0; j < 3; j++)
    {
        Console.Write($"{mat[i,j]}\t");
    }
    Console.WriteLine();
}