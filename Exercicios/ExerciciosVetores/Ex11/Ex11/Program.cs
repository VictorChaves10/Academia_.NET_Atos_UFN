//Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

int[] vect = new int[5];

for(int i= 0; i < 5; i++)
{
    Console.Write($"Digite o valor na posição {i+1}: ");
    vect[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nEsses são os valores ordenados da lista: ");

for (int i = 0; i < 5; i++)
{
    Console.Write($"{vect[i]} ");
}

Console.Write("\nEsses são os valores inversos da lista: ");

for (int i = 4; i >= 0; i--)
{
    Console.Write($"{vect[i]} ");
}