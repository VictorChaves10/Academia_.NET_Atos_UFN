

int codigoA, codigoB, quantidadeA, quantidadeB;
double valorA, valorB, ipi;


Console.Write("Digite o código do parafuso A: ");
codigoA = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade do parafuso A: ");
quantidadeA = int.Parse(Console.ReadLine());

Console.Write("Digite o valor unitário do parafuso A: ");
valorA = double.Parse(Console.ReadLine());

Console.Write("\nDigite o código do parafuso B: ");
codigoB = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade do parafuso B: ");
quantidadeB = int.Parse(Console.ReadLine());

Console.Write("Digite o valor unitário do parafuso B: ");
valorB = double.Parse(Console.ReadLine());

Console.Write("Digite a porcentagem de IPI: ");
ipi = double.Parse(Console.ReadLine());

double totalA = valorA * quantidadeA;
double totalB = valorB * quantidadeB;

Console.WriteLine($"\nDados do parafuso A: código: {codigoA}, quantidade: {quantidadeA}un, valor total em estoque: {totalA.ToString("F2")}");

Console.WriteLine($"\nDados do parafuso A: código: {codigoB}, quantidade: {quantidadeB}un, valor total em estoque: {totalB.ToString("F2")}");