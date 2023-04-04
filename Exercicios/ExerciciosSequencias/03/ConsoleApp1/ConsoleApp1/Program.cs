


int a, b,aux;

Console.Write("Digite o valor de A: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine($"A:{a}  B:{b}");
aux = a;
a = b;
b = aux;

Console.WriteLine($"A:{a}  B:{b}");