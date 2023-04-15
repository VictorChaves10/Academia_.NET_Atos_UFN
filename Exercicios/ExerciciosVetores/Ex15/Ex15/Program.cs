//Faça um programa em C# que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

int[] vect = new int[20];
int[] vect2 = new int[20];

Random valueVect = new Random();
Console.Write("Digite os valores: ");

for(int i = 0; i < 20; i++)
{
    vect[i] = valueVect.Next(0, 30);
    Console.Write($"{vect[i]} ");
}

int j = 0;
int x = 19;

while ( j < 20)
{
    
    vect2[x] = vect[j];
    j++;
    x--;
}

Console.WriteLine();

for (int i = 0; i < 20; i++)
{
    Console.Write($"{vect[i]} ");
}
Console.WriteLine();

for (int i = 0; i < 20; i++)
{
    Console.Write($"{vect2[i]} ");
}
