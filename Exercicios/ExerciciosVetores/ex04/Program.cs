//Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

int[] vet1 = new int[10], vet2 = new int[10], vetResult = new int[10];

for (int i = 0; i < 10; i++)
{
    Random valorVetor = new Random();
    Console.Write($"Digite o valor para o vetor 1 na posição {i + 1}: ");
    vet1[i] = valorVetor.Next(50);
    Console.WriteLine(vet1[i]);

    Console.Write($"Digite o valor para o vetor 2 na posição {i + 1}: ");
    vet2[i] = valorVetor.Next(50);
    vetResult[i] = vet1[i] * vet2[i];
    Console.WriteLine(vet2[i]);

    Console.WriteLine($"\nO resultado da multiplicação dos vetores é: {vetResult[i]}\n");
}