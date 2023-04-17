//Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
//Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

int[,] mat = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Digite o valor da coluna {i + 1} e linha {j + 1}: ");
        mat[j, i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

Console.Write("\nDigite o valor de pesquisa: ");
int n = int.Parse(Console.ReadLine());
bool pesquisa = false;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (n == mat[j, i])
        {
            Console.WriteLine("O número existe no vetor");
            pesquisa = true;
            break;
        }
    }

    if (i == 2)
    {
        Console.WriteLine("Número inexistente");
    }
    else if (pesquisa)
    {
        break;
    }

}


