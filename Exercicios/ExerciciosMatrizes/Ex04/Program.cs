//4) Popule uma matriz 5x5 e informe:
//-Quantos números são pares
//-Quantos números são impares
//-Quantos números são positivos
//-Quantos números são negativos
//-Quantos zeros existem!



int par = 0;
int impar = 0;
int negativo = 0;
int positivo = 0;
int numbersZero = 0;

int[,] mat = new int[5, 5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"Digite o valor da coluna {i + 1} e linha {j + 1}: ");
        mat[j, i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

//valores pares e impares

for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {
        if (mat[i, j] % 2 == 0)
        {
            par++;
        }
        else
        {
            impar++;
        }
    }

}

// negativos e positivos

for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {
        if (mat[i, j] > 0)
        {
            positivo++;
        }
        else
        {
            negativo++;
        }
    }

}
// números zero

for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {
        if (mat[i, j] == 0)
        {
            positivo++;
        }

    }

}


for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{mat[i,j]}   ");

    }
    Console.WriteLine();
}

Console.WriteLine($"\nQuantidade de números pares: {par}");
Console.WriteLine($"Quantidade de números impares: {impar}");
Console.WriteLine($"Quantidade de números positivoss: {positivo}");
Console.WriteLine($"Quantidade de números negativos: {negativo}");
Console.WriteLine($"Quantidade de números zeros: {numbersZero}");

Console.ReadLine();