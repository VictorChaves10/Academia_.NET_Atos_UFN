//Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!


int[,] mat = new int[4, 4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"Infome o valor da coluna {i + 1}, linha {j + 1}: ");
        mat[j, i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{mat[i, j]}  ");
    }
    Console.WriteLine();
}

Console.WriteLine();
//imprime na diagonal

for (int i = 0; i < 4; i++)
{
    switch (i)
    {

        case 0:
            Console.WriteLine($"{mat[i, i]}");
            break;
        case 1:
            Console.WriteLine($"    {mat[i, i]}");
            break;
        case 2:
            Console.WriteLine($"\t{mat[i, i]}");
            break;
        case 3:
            Console.WriteLine($"\t    {mat[i, i]}");
            break;
    }

}
