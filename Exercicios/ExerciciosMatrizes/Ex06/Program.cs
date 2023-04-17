//Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
//Random random = new Random();
//int randomNumber = random.Next(0, 100);


Random valueMat = new Random();

int[,] mat = new int[4, 4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        mat[j, i] = valueMat.Next(1, 9);
    }
}

// imprimir a matriz

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{mat[i, j]}   ");
    }
    Console.WriteLine();
}

//comparação

int compara = mat[0, 0];
int menor = 0;

for (int i = 0; i < 4; i++)
{
   
     menor = compara;

    for (int j = 0; j < 4; j++)
    {
        if (menor <= mat[j, i])
        {
            menor = menor;
        }
        else
        {
            menor = mat[j, i];
        }
    }

    compara = menor;
}
//resultado

Console.WriteLine(menor);