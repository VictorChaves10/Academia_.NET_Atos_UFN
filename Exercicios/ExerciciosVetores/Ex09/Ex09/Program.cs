
class Program
{
    static void Main(string[] args) { 

        int[] vetor = new int[10];
        Console.WriteLine("Digite 10 valores para o vetor:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 9; i++)
        {
            int menor = i;

            for (int j = i + 1; j < 10; j++)
            {
                if (vetor[j] < vetor[menor])
                {
                    menor = j;
                }
            }
            int temp = vetor[i];
            vetor[i] = vetor[menor];
            vetor[menor] = temp;
        }

        Console.WriteLine("\nVetor ordenado em ordem crescente:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Valor {i + 1}: {vetor[i]}");
        }
    }
}
