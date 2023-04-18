//Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.




int[,] matA = new int[3, 4];
int[,] matB = new int[4, 3];

Random valueMat = new Random();


for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matA[j, i] = valueMat.Next(0, 20);

    }
}



for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matA[i, j].ToString("D2")}\t");
    }
    Console.WriteLine();
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j <= 3; j++)
    {
        matB[j, i] = matA[i, j];
    }
}
Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{matB[i, j].ToString("D2")}\t");

    }
    Console.WriteLine();
}


