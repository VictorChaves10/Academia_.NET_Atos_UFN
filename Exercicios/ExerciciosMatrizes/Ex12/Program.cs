//Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

int[,] mat = new int[4, 3];
Random valueMat= new Random();

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        mat[j, i] = valueMat.Next(0, 20);
    }
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{mat[j, i].ToString("D2")}\t"); 
    }
    Console.WriteLine();
}

Console.WriteLine();
//somente valores pares
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if((i+j) % 2== 0)
        {
            Console.Write($"{mat[j, i]}  ");
        }
        
    }
}
Console.WriteLine();
