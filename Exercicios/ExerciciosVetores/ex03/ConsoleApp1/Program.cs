//Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.


int[] vet = new int[20];
Random valorVet= new Random();


for (int i = 0;i < 20; i++)
{
    Console.Write($"Digite o valor na posição {i + 1} do vetor: ");
    vet[i] = valorVet.Next(1,100);
    Console.WriteLine(vet[i]);
    
}
Console.WriteLine();
for(int i = 0; i < 20; i++) {

    int primo = 0;

    for (int x = 1; x <= vet[i]; x++){
        
        if (vet[i] % x == 0)
        {
            primo++;
        }
    
    }

    if (primo > 2)
    {
        Console.WriteLine($"O valor {vet[i]} na posição {i+1} não é primo");
    }
    else
    {
        Console.WriteLine($"O valor {vet[i]} na posição {i+1} é primo");
    }

}
