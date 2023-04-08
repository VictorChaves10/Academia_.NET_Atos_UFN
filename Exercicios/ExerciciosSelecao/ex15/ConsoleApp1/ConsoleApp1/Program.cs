




double metrosQuadrados;
int qtdLatas;
double precoTotal;

Console.Write("Informe a área a ser pintada em metros quadrados: ");
metrosQuadrados = double.Parse(Console.ReadLine());

qtdLatas = (int)Math.Ceiling(metrosQuadrados / 54);

precoTotal = qtdLatas * 80;

Console.WriteLine("Você precisará de " + qtdLatas + " latas de tinta, ao custo total de R$" + precoTotal.ToString("F2"));

