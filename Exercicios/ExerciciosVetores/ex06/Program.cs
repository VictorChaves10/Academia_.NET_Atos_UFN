//Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
//a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
//b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |


int[] vect = new int[10];

Console.Write("Informe os valores: ");
string[] valueVect = Console.ReadLine().Split(' ');

while (valueVect.Length > 10)
{
    Console.Write("Informe os valores: ");
    valueVect = Console.ReadLine().Split(' ');
}
for (int i = 0; i < 10; i++)
{
    vect[i] = int.Parse(valueVect[i]);

}
Console.Write("\nOs valores invertido: ");

for (int i = 9; i >= 0; i--)
{
    Console.Write($"{vect[i]} ");
}
Console.WriteLine();

