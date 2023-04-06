



double salarioMin,valorBicicleta,bicicletaUn, salarioFinal;

Console.Write("Qual o valor do salário mínimo: ");
salarioMin = double.Parse(Console.ReadLine());

Console.Write("Informe o valor da bicicleta (un): ");
valorBicicleta = double.Parse(Console.ReadLine());

Console.Write("Quantas bicicletas foi vendida (un): ");
bicicletaUn= double.Parse(Console.ReadLine());

valorBicicleta += valorBicicleta * 50.00 / 100.00;


salarioFinal = ((bicicletaUn * valorBicicleta) * 15.00 / 100.00) + (salarioMin * 2);

Console.WriteLine("O seu sálario é de: R$"+salarioFinal.ToString("F2"));

