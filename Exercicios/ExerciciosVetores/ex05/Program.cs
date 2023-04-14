//Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.


int[] vet = new int[80];
Random numberVet = new Random();
int menor = 0;
int x = 0;

for (int i = 0; i < 80; i++)
{
    Console.Write($"Na posição {i + 1}, digite o seu valor : ");
    vet[i] = numberVet.Next(0, 50);
    Console.WriteLine(vet[i]);

}

for (int i = 0; i < 80; i++)

{

    for (x = 0; x < 80; x++)
    {
        if (vet[i] <= vet[x]) //if com o valor do vetor, se ele for maior que qualquer outro para e pula pro proximo.
        {
            menor = vet[i];
        }
        else
        {
            break;
        }

    }

    if (x == 80)
    {
        Console.WriteLine($"\nO numero menor é o {menor} na posição {i+1} ");
        break;
    }

}