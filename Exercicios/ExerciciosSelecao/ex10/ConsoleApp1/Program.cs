

string nome1, nome2;
int idade1, idade2;
double altura1, altura2;

Console.WriteLine("Atleta 1:");

Console.Write("\nDigite seu nome: ");
nome1 = Console.ReadLine();
Console.Write("Infome sua idade: ");
idade1 = int.Parse(Console.ReadLine());
Console.Write("Infome sua altura: ");
altura1 = double.Parse(Console.ReadLine());

Console.WriteLine("\nAtleta 2:");

Console.Write("\nDigite seu nome: ");
nome2 = Console.ReadLine();
Console.Write("Infome sua idade: ");
idade2 = int.Parse(Console.ReadLine());
Console.Write("Infome sua altura: ");
altura2 = double.Parse(Console.ReadLine());

if(idade1 < idade2 || altura1 > altura2)
{
    Console.WriteLine($"O atleta {nome1} é mais novo e mais alto.");
}
else
{
    Console.WriteLine($"O atleta {nome2} é mais novo e mais alto.");
}


