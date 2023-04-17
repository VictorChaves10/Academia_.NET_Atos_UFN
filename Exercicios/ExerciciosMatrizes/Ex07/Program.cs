//Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.


Random valueMat = new Random();

int[,] matA = new int[3, 3];
int[,] matB = new int[3, 3];
int[,] matC = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matA[j, i] = valueMat.Next(0, 20);
        matB[j, i] = valueMat.Next(0, 20);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (matA[j,i] > matB[j, i])
        {
            matC[j, i] =  matA[j, i] - matB[j, i];
        }
        else
        {
            matC[j, i] = matB[j, i] - matA[j, i];
        }
        
    }
}

Console.WriteLine("Matriz A\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{matA[j,i]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nMatriz B\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{matB[j, i]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nMatriz C\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{matC[j,i]}\t");
    }
    Console.WriteLine();
}