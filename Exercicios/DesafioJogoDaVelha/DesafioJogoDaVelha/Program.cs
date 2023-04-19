

char[,] tabuleiro = new char[3, 3];

char player1 = 'X';
char player2 = 'O';

tabuleiro[1, 1] = player1;






// ___________________________________
//|           |           |           |
//|     X     |           |     O     |
//|___________|___________|___________|
//|           |           |           |
//|           |     X     |           |
//|___________|___________|___________|
//|           |           |           |
//|     O     |     X     |           |
//|___________|___________|___________|

Console.WriteLine("            0       1       2");
Console.WriteLine("\t _______________________");
Console.WriteLine("\t|\t|\t|\t|");
Console.WriteLine($"   0\t|   {tabuleiro[0,0]}\t|   {tabuleiro[0,1]}\t|   {tabuleiro[0,2]}\t|");
Console.WriteLine("\t|_______|_______|_______|");
Console.WriteLine("\t|\t|\t|\t|");
Console.WriteLine($"   1\t|   {tabuleiro[1, 0]}\t|   {tabuleiro[1, 1]}\t|   {tabuleiro[1, 2]}\t|");
Console.WriteLine("\t|_______|_______|_______|");
Console.WriteLine("\t|\t|\t|\t|");
Console.WriteLine($"   2\t|   {tabuleiro[2, 0]}\t|   {tabuleiro[2, 1]}\t|   {tabuleiro[2, 2]}\t|");
Console.WriteLine("\t|_______|_______|_______|");


// Condições de vitória

for()
