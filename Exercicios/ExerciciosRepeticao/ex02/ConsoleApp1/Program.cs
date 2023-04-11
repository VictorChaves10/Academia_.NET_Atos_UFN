




int i, n, maior;
Console.WriteLine("Digite um valor: ");
maior = int.Parse(Console.ReadLine());

for (i = 0; i < 9; i++)
{
    Console.WriteLine("Digite um valor: ");
    n = int.Parse(Console.ReadLine());

    if (n > maior) { 
        maior = n; 
    }
}

Console.WriteLine("O maior valor digitado foi: " + maior);







