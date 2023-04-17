//Leia duas matrizes 2x3 de números double. 
//Imprima a soma destas duas matrizes.

double[,] mat1 = new double[2, 3];
double[,] mat2 = new double[2, 3];

Console.WriteLine("Matriz 1\n");

for (int i = 0; i < 3; i++)
{
    for(int j= 0; j < 2; j++)
    {
        Console.Write($"Digite o valor da coluna {i+1} e linha {j+1}: ");
        mat1[j,i] = double.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

Console.WriteLine("Matriz 2 \n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"Digite o valor da coluna {i+1} e linha {j+1}: ");
        mat2[j, i] = double.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

//imprimir os valores
Console.WriteLine("Somas das matrizes:\n");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{mat1[i,j] + mat2[i,j]}  ");

    }
    Console.WriteLine();
}

