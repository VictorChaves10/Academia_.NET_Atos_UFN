//2Solicite ao usuário, preencher uma Matriz 3x3

//Informe ao usuário:
//*A soma dos elementos de cada linha
//	-Ex: Linha 1: 30

//		 Linha 2: 17
//* A soma dos elementos de cada coluna
//	-Ex: Coluna 1: 23

//		 Coluna 2: 36




using System.Globalization;

int[,] mat = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Informe o valor da coluna {i + 1} e linha {j + 1}: ");
        mat[j, i] = int.Parse(Console.ReadLine());

    }
    Console.WriteLine();
}

for (int i = 0; i < 3; i++)
{
    int temp = 0;
    for (int j = 0; j < 3; j++)
    {
        int soma = mat[j, i] + temp;
        temp = soma;
    }
    Console.WriteLine($"A soma das linhas da coluna {i + 1} é : {temp}");

}
Console.WriteLine();
    ;
for (int i = 0; i < 3; i++)
{
    int temp = 0;
    for (int j = 0; j < 3; j++)
    {
        int soma = mat[i,j] + temp;
        temp = soma;
    }
    Console.WriteLine($"A soma das colunas da linha {i+1} é : {temp}");

}