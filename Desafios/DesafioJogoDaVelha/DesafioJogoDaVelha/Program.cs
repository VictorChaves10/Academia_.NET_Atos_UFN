


using System.Diagnostics;

namespace JogoDaVelha
{
    class Program
    {
        static char[,] tabuleiro = new char[3, 3];

        static int player1Victory = 0; // Placar de vitória 'X'
        static int player2Victory = 0; // Placar de vitória 'O'
        static int drawgame = 0; // Empates

        static int player = 1;  // Acompanhar o jogador da vez

        static int line, column; // Armaze a escolha do jogador

        static int flag = 0; // Variável para indicar o status do jogo (0 para jogo em andamento, 1 para vitória de um jogador, 2  para empate)
        static DateTime temp = DateTime.Now;
        static string t1 = temp.ToLongTimeString();
        static void Main(string[] args)
        {
            Console.WriteLine(Tabuleiro());

            do
            {

                bool jogada = false;

                if (player % 2 != 0)
                {
                    while (jogada == false)
                    {
                        Console.WriteLine($"\tJogador da vez: Player 1 'X' \n");

                        Console.Write("\tInforme a linha desejada: ");
                        line = int.Parse(Console.ReadLine());

                        Console.Write("\tInforme a coluna desejada: ");
                        column = int.Parse(Console.ReadLine());

                        if (JogadaValida(column, line))
                        {
                            tabuleiro[line, column] = 'X';
                            jogada = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Tabuleiro());
                            Console.WriteLine("\t    (Jogada Inválida!)\n");

                        }
                    }
                }
                else
                {
                    while (jogada == false)
                    {
                        Console.WriteLine($"\tJogador da vez: Player 2 'O' \n");
                        Console.Write("\tInforme a linha desejada: ");
                        line = int.Parse(Console.ReadLine());

                        Console.Write("\tInforme a coluna desejada: ");
                        column = int.Parse(Console.ReadLine());

                        if (JogadaValida(column, line))
                        {
                            tabuleiro[line, column] = 'O';
                            jogada = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Tabuleiro());
                            Console.WriteLine("\t    (Jogada Inválida!)\n");
                        }
                    }

                }

                flag = Winner();
                player++;

                Console.Clear();
                Console.WriteLine(Tabuleiro());

                if (flag == 1)
                {
                    if (player % 2 == 0)
                    {
                        player1Victory++;
                        Console.WriteLine("\n\t    Jogador 1 venceu!");
                        Console.Write("\n Deseja jogar novamente? (digite 0 para continuar ou aperte qualquer outra tecla para encerrar): ");
                        int x = int.Parse(Console.ReadLine());
                        if (x == 0)
                        {
                            ResetGame();

                        }

                    }
                    else
                    {
                        player2Victory++;
                        Console.WriteLine("\n\t    Jogador 2 ganhou!");
                        Console.Write("\n Deseja jogar novamente? (digite 0 para continuar ou aperte qualquer outra tecla para encerrar): ");
                        int x = int.Parse(Console.ReadLine());
                        if (x == 0)
                        {
                            ResetGame();

                        }
                    }
                }
                else if (flag == 2)
                {

                    drawgame++;

                    Console.WriteLine("\n\t      Empate!");
                    Console.Write("\n Deseja jogar novamente? (digite 0 para continuar ou aperte qualquer outra tecla para encerrar): ");
                    int x = int.Parse(Console.ReadLine());
                    if (x == 0)
                    {
                        ResetGame();

                    }
                }


            } while (flag == 0);


        }
        public static string Tabuleiro()
        {
            return "\n             JOGO DA VELHA\n\n"
                 + $"  Player1 (X)  [ {player1Victory} ] x [ {player2Victory} ]  Player2 (O)  \tEmpates: [ {drawgame} ]\n\n"
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

        public static void ResetGame() // Limpa os valores da matriz para uma nova partida
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = '\0';
                }

            }

            player = 1;
            flag = 0;
            Console.Clear();
            Console.WriteLine(Tabuleiro());


        }
        public static bool JogadaValida(int column, int rowl) // Verifica se a jogada ultrapassa o tamanho da matriz ou se o indice ja está preenchido.
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

        public static int Winner() // Verifica se existe um ganhador
        {
            int x;
            if (LinhaHorizontal())
            {
                x = 1;
            }
            else if (LinhaVertical())
            {
                x = 1;
            }
            else if (VerticalPrincipal())
            {
                x = 1;
            }
            else if (VeritcalSecundaria())
            {
                x = 1;
            }
            else if (player == 9)
            {
                x = 2;
            }
            else
            {
                x = 0;
            }

            return x;
        }

        public static bool LinhaHorizontal() // Verifica as linhas horinzontais
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < 3; i++)
            {

                x = 0;
                y = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j] == 'X')
                    {
                        x++;
                    }
                    else if (tabuleiro[i, j] == 'O')
                    {
                        y++;
                    }
                }
                if (x == 3 || y == 3)
                {
                    break;
                }

            }

            if (x == 3)
            {
                return true;
            }
            else if (y == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool LinhaVertical() //Verifica as linhas verticais
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < 3; i++)
            {
                x = 0;
                y = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[j, i] == 'X')
                    {
                        x++;
                    }
                    else if (tabuleiro[j, i] == 'O')
                    {
                        y++;
                    }
                }
                if(x == 3 || y == 3)
                {
                    break;
                }
            }

            if (x == 3)
            {
                return true;
            }
            else if (y == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool VerticalPrincipal()  //Verifica a diagonal principal
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, i] == 'X')
                {
                    x++;
                }
                else if (tabuleiro[i, i] == 'O')
                {
                    y++;

                }
            }

            if (x == 3)
            {
                return true;
            }
            else if (y == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VeritcalSecundaria()  //Verifica a diagonal secundária
        {
            int x = 0;
            int y = 0;

            int j = 0;

            for (int i = 2; i >= 0; i--)
            {

                if (tabuleiro[j, i] == 'X')
                {
                    x++;
                }
                else if (tabuleiro[j, i] == 'O')
                {
                    y++;

                }

                j++;
            }

            if (x == 3)
            {
                return true;
            }
            else if (y == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
