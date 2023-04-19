


char[,] tabuleiro = new char[3, 3];
char player1 = 'X';
char player2 = 'O';
int line = 0;
int column = 0;

int x = 0;
int o = 0;
//Tabuleiro
Console.WriteLine("             JOGO DA VELHA\n\n");
Console.WriteLine($"  Player1 (X) [ {x} ] x [ {o} ] Player2 (O)  \tEmpates: [ {x} ]\n\n");
Console.WriteLine("            A       B       C");
Console.WriteLine("\t _______________________");
Console.WriteLine("\t|\t|\t|\t|");
Console.WriteLine($"   0\t|   {tabuleiro[0, 0]}\t|   {tabuleiro[0, 1]}\t|   {tabuleiro[0, 2]}\t|");
Console.WriteLine("\t|_______|_______|_______|");
Console.WriteLine("\t|\t|\t|\t|");
Console.WriteLine($"   1\t|   {tabuleiro[1, 0]}\t|   {tabuleiro[1, 1]}\t|   {tabuleiro[1, 2]}\t|");
Console.WriteLine("\t|_______|_______|_______|");
Console.WriteLine("\t|\t|\t|\t|");
Console.WriteLine($"   2\t|   {tabuleiro[2, 0]}\t|   {tabuleiro[2, 1]}\t|   {tabuleiro[2, 2]}\t|");
Console.WriteLine("\t|_______|_______|_______|\n");



Console.Write("\tInforme a coluna desejada: ");
column = int.Parse(Console.ReadLine());

Console.Write("\tInforme a linha desejada: ");
line = int.Parse(Console.ReadLine());

Console.Clear();

tabuleiro[line, column] = 'X';

/* verificando as linhas horizontais

for (int i = 0; i < 3; i++)
{
     x = 0;
     o = 0;
    for (int j = 0; j < 3; j++)
    {
        if (tabuleiro[i, j] == player1)
        {
            x++;
        }
        else if (tabuleiro[i, j] == player2)
        {
            o++;
        }
    }

}

//verificando as linhas verticas

for (int i = 0; i < 3; i++)
{
     x = 0;
     o = 0;
    for (int j = 0; j < 3; j++)
    {
        if (tabuleiro[j, i] == player1)
        {
            x++;
        }
        else if (tabuleiro[j, i] == player2)
        {
            o++;
        }
    }
}

//verificando a diagonal principal

x = 0;
o = 0;
for (int i = 0; i < 3; i++)
{ 

    if (tabuleiro[i, i] == player1)
    {
        x++;
    }
    else if (tabuleiro[i, i] == player2)
    {
        o++;

    }

}

// Condições de vitória

static int Victory(int x)
{
    int player1 = 0;

    int player2 = 0;

    if (x == 3)
    {
        player1++;
        return player1;
    }
    else if (y == 3)
    {
        player2++;
        return player2;
    }
    else
    {
        return 0;
    }
}
*/