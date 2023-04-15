//Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

Random valueVect = new Random();

int[] vect = new int[50];
Console.Write("Digite os valores: ");
for (int i = 0; i < 50; i++)
{
    vect[i] = valueVect.Next(0, 50);
    
    Console.Write($"{vect[i]} ");
}

Console.WriteLine("\n\nO que gostaria de realizar:\n\n(0) - Finalizar\n(1) - Mostrar a lista\n(2) - Mostrar a lista inversa");
Console.Write("\nDigite a opção desejada: ");
int option = int.Parse(Console.ReadLine());


while (option < 0 && option > 3)
{
    Console.Write("\nOpção inválida, digite a opção desejada: ");
    option = int.Parse(Console.ReadLine());
}

switch (option)
{
    case 0: 
        break;

    case 1:
        for (int i = 0; i < 50; i++)
        {
            Console.Write($"{vect[i]} "); 
        }
        break;
    case 2:
        for (int i = 49; i >= 0; i--)
        {
            Console.Write($"{vect[i]} ");
        }
        break;
}