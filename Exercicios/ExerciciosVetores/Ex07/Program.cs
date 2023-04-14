//Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
//a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
//b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |


int[] vect = new int[10];
Console.Write("Digite os valores: ");
string[] valueVect = Console.ReadLine().Split(' ');

while(valueVect.Length > 10 || valueVect.Length < 2)
{
    Console.Write("Digite os valores: ");
    valueVect = Console.ReadLine().Split(' ');
}

for(int i= 0; i < 10; i++)
{
    vect[i] = int.Parse(valueVect[i]);
}
Console.Write("\nSegue os valores começando pelos pares: ");

for (int i = 0; i < 10; i++)
{
    if (vect[i] % 2 == 0)
    Console.Write($"{vect[i]} ");

}
for (int x = 0; x < 10; x++)
{
    if (vect[x] % 2 != 0)
        Console.Write($"{vect[x]} ");
}
Console.WriteLine();