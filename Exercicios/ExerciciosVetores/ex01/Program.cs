//Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.


int par = 0; 
int impar =0;

int[] vet = new int[10];

for (int i = 0; i <10; i++)
{
    Console.Write($"Digite o valor para o vetor {i+1}: ");
    vet[i] = int.Parse( Console.ReadLine());

    if (vet[i] % 2 ==0)
    {
        par++;
    }
    else
    {
        impar++;
    }
}

Console.WriteLine($"\nDentre os números digitados {par} são pares e {impar} são impares!");

