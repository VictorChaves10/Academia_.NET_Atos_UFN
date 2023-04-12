//1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
//Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

using System.Drawing;

Console.Write("Informe um número inteiro e positivo: ");
int x = int.Parse(Console.ReadLine());

while (x < 0)
{
    Console.Write("Informe um número inteiro e positivo: ");
    x = int.Parse(Console.ReadLine());
}

for (int i = 1; i < x; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
}