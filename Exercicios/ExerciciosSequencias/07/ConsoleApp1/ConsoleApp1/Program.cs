


int codigoVendedor;
double salarioFixo, comissao, totalVendas, salarioFinal;


Console.Write("Digite o código do vendedor: ");
codigoVendedor = int.Parse(Console.ReadLine());

Console.Write("Informe o sálario fixo do vendedor: ");
salarioFixo= double.Parse(Console.ReadLine());

Console.Write("Informe o valor que foi vendido no mês: ");
totalVendas= double.Parse(Console.ReadLine());

Console.Write("Qual a porcentagem de comissão: ");
comissao = double.Parse(Console.ReadLine());

salarioFinal = (totalVendas * comissao / 100.00) + salarioFixo;


Console.WriteLine($"\nVendedor: {codigoVendedor}, Sálario Final: {salarioFinal.ToString("F2")}");


