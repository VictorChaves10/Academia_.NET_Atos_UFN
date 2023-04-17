//Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.



int[,] matA = new int[4, 4];
int[,] matB = new int[4, 4];

Random valueMat = new Random();

for (int i = 0; i < 4; i++)
{
    for(int j = 0; j < 4; j++)
    {
        matA[j, i] = valueMat.Next(0, 20);
        matB[j, i] = valueMat.Next(0, 20);
    }
}

//imprimir as matrizes para mais facil indentificar

Console.WriteLine("Matriz A\n");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matA[j, i]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nMatriz B\n");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matB[j, i]}\t");
    }
    Console.WriteLine();
}

//media
int igualMedia = 0;
int foraDaMedia=0;
int acimaDaMedia=0;
int media;

for (int i = 0; i < 4; i++)
{
    

    for (int j = 0; j < 4; j++)
    {
        media = (matA[j, i] + matB[j, i]) / 2;

        if (matA[j, i] > media || matB[j, i] > media)
        {   
            if(matA[j, i] > media && matB[j, i] > media)
            {
                acimaDaMedia += 2;
            }
            else
            {
                acimaDaMedia++;
            }
           
        }

        if (matA[j, i] < media || matB[j, i] < media)
        {
            if (matA[j, i] > media && matB[j, i] > media)
            {
                foraDaMedia += 2;
            }
            else
            {
                foraDaMedia++;
            }

        }

        if (matA[j, i] < media || matB[j, i] < media)
        {
            if (matA[j, i] > media && matB[j, i] > media)
            {
                foraDaMedia += 2;
            }
            else
            {
                foraDaMedia++;
            }

        }

        if (matA[j, i] == media || matB[j, i] == media)
        {
            if (matA[j, i] > media && matB[j, i] > media)
            {
                igualMedia+= 2;
            }
            else
            {
                igualMedia++;
            }

        }

    }

}

Console.WriteLine($"\nTotal acima da media: {acimaDaMedia}");
Console.WriteLine($"\nTotal na média: {igualMedia}");
Console.WriteLine($"\nTotal fora da media: {foraDaMedia}");