



double salario, aumento;

double salarioFinal = 0.00;

Console.Write( "informe seu salário: ");
salario = double.Parse(Console.ReadLine());

if(salario <= 900.00)
{
    aumento = salario * 5.00 / 100.00;
    salarioFinal = aumento + salario;

    Console.WriteLine($"Salário atual: R$ {salario.ToString("F2")}, Aumento em reais: {aumento.ToString("F2")}, Porcentagem: 5%, Novo Salário: {salarioFinal.ToString("F2")} ");
}
else if (salario < 1400.00)
{
    aumento = salario * 8.00 / 100.00;
    salarioFinal = aumento + salario;
    Console.WriteLine($"Salário atual: R$ {salario.ToString("F2")}, Aumento em reais: {aumento.ToString("F2")}, Porcentagem: 8%, Novo Salário: {salarioFinal.ToString("F2")} ");
}
else
{
    aumento = salario * 10.00 / 100.00;
    salarioFinal = aumento + salario;
    Console.WriteLine($"Salário atual: R$ {salario.ToString("F2")}, Aumento em reais: {aumento.ToString("F2")}, Porcentagem: 10%, Novo Salário: {salarioFinal.ToString("F2")} ");
}

