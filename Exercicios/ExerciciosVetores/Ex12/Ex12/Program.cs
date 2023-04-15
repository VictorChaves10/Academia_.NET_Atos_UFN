//Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".


int[] vet = new int[10];
Random valueVect = new Random();

Console.Write("Os valores do vertor são: ");
for (int i = 0; i < 10; i++)
{
    vet[i] = valueVect.Next(0, 20);
    Console.Write($"{vet[i]} ");
}

Console.Write("\nInforme o valor que deseja consultar: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    if(vet[i] == n)
    {
        Console.WriteLine($"O valor está na posição: {i+1}");
        break;
    }
    else if( i == 9){

        Console.WriteLine("O número fornecido não existe no vetor!");
    }
}

