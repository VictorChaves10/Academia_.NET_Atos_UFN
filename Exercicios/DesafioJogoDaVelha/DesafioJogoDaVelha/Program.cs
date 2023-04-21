


namespace JogoDaVelha
{
    class Program
    {
        static char[,] tabuleiro = new char[3, 3];
        static int player1Victory = 0;
        static int player2Victory = 0;
        static int player = 1;
        static int line = 0;
        static int column = 0;
    
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine(Tabuleiro());
                bool jogada = false;

                if (player % 2 != 0)
                {
                    while (jogada == false)
                    {
                        Console.WriteLine($"\tJogador da vez: Player 1 'X' \n");
                        Console.Write("\tInforme a coluna desejada: ");
                        column = int.Parse(Console.ReadLine());

                        Console.Write("\tInforme a linha desejada: ");
                        line = int.Parse(Console.ReadLine());
                      
                        if (JogadaValida(column, line))
                        {
                            tabuleiro[line, column] = 'X';
                            jogada = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Tabuleiro());
                            Console.WriteLine("   \t(Jogada Inválida!)\n");
                            
                        }
                    }
                }
                else
                {
                    while (jogada == false)
                    {
                        Console.WriteLine($"\tJogador da vez: Player 2 'O' \n");
                        Console.Write("\tInforme a coluna desejada: ");
                        column = int.Parse(Console.ReadLine());

                        Console.Write("\tInforme a linha desejada: ");
                        line = int.Parse(Console.ReadLine());

                        if (JogadaValida(column, line))
                        {
                            tabuleiro[line, column] = 'O';
                            jogada = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Tabuleiro());
                            Console.WriteLine("   \t(Jogada Inválida!)\n");
                        }
                    }

                }

                player++;

            } while (player > 0);


        }

        public static string Tabuleiro()
        {
            return "             JOGO DA VELHA\n\n"
                 + $"  Player1 (X)  [ {player1Victory} ] x [ {player2Victory} ]  Player2 ('O')  \tEmpates: [ {0} ]\n\n"
                 + "            0       1       2\n"
                 + "\t _______________________\n"
                 + "\t|\t|\t|\t|\n"
                 + $"   0\t|   {tabuleiro[0, 0]}\t|   {tabuleiro[0, 1]}\t|   {tabuleiro[0, 2]}\t|\n"
                 + "\t|_______|_______|_______|\n"
                 + "\t|\t|\t|\t|\n"
                 + $"   1\t|   {tabuleiro[1, 0]}\t|   {tabuleiro[1, 1]}\t|   {tabuleiro[1, 2]}\t|\n"
                 + "\t|_______|_______|_______|\n"
                 + "\t|\t|\t|\t|\n"
                 + $"   2\t|   {tabuleiro[2, 0]}\t|   {tabuleiro[2, 1]}\t|   {tabuleiro[2, 2]}\t|\n"
                 + "\t|_______|_______|_______|\n";
        }


        public static bool JogadaValida(int column, int rowl)
        {
            if ((column <= 2 && column >= 0) && (rowl <= 2 && rowl >= 0))
            {
                if (tabuleiro[rowl, column] != '\0')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }


        }

    }
}

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