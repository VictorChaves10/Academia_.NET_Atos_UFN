
//Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
//a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
//b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .


Random valueVectDouble = new Random();
Random valueVect = new Random();

double[] vect = new double[30];
Console.Write("Informe os valores: ");

for (int i = 0; i < 5; i++)
{
    vect[i] = valueVect.NextDouble() + valueVect.Next(-10, 10);
    Console.Write(vect[i].ToString("F2") + " ");
}

Console.Write("\nOs números negativos estão na posição: ");

for (int i = 0; i < 30; i++)
{

    if (vect[i] < 0)
    {
        Console.Write($"{i + 1} ");
    }
}
Console.WriteLine();