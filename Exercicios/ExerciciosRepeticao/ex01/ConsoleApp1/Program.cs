

////1 - Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
//pessoas e calcular a média das idades.


Console.Write("Informe a quantidade de pessoas que será informado a idade: ");
int x = int.Parse(Console.ReadLine());
double media = 0;


for(int i = 0; i < x; i++)
{
    int idade = int.Parse(Console.ReadLine());
    media += idade;
}

Console.WriteLine(media / x);

