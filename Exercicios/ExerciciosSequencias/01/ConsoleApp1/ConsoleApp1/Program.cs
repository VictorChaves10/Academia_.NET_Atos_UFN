



Console.WriteLine("Digite dois valores: ");

double valor1, valor2;

valor1 = double.Parse(Console.ReadLine());
valor2 = double.Parse(Console.ReadLine());

double media = (valor1 + valor2) / 2;

Console.WriteLine("Média: " + media.ToString("F2"));
