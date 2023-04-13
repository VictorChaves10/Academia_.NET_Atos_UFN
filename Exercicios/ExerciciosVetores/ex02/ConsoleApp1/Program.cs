


//Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.


int[] vet1 = new int[20], vet2 = new int[20], vetResult = new int[20];

for (int i = 0; i < 20; i++)
{
    Random valorVetor = new Random(); 
    Console.Write($"Digite o valor para o vetor 1 na posição {i+1}: ");
    vet1[i] = valorVetor.Next( 50);
    Console.WriteLine(vet1[i]);

    Console.Write($"Digite o valor para o vetor 2 na posição {i + 1}: ");
    vet2[i] = valorVetor.Next(50);
    vetResult[i] = vet1[i] + vet2[i];
    Console.WriteLine(vet2[i]);

    Console.WriteLine($"\nO resultado da soma dos vetores na posição {i +1} é: {vetResult[i]}\n");
}


