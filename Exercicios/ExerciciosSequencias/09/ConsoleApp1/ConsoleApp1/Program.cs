




Console.Write("informe o valor da mercadoria: ");

double valorMercadoria = double.Parse(Console.ReadLine());


double valorParcelas = valorMercadoria / 4;

double valorEntrada = valorParcelas * 2;


Console.WriteLine($"Valor entrada: $ {valorEntrada.ToString("F2")}");

Console.WriteLine($"Valor parcelas: $ {valorParcelas.ToString("F2")}");

   

