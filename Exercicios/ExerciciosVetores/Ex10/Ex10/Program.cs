
//Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.


int[] vect = new int[5];

for(int i= 0; i < 5; i++)
{
    Console.Write($"Digite o valor da posição {i+1}: ");
    vect[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nEsse é seu vetor: ");
for(int i = 0; i < 5; i++)
{
    Console.Write($"{vect[i]} ");
}

for (int i = 0; i < 5; i++){

        if(vect[i] == 0)
        {
           vect[i] = 2;

        }
}

Console.WriteLine("\nEsse é seu vetor sem valores nulos: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{vect[i]} ");
}