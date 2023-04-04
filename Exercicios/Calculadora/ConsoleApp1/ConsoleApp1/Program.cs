



using System;

Console.Write("Digite a operação desejada conforme tabela: 1 Soma, 2 Subtração, 3 Divisão, 4 Multiplicação: ");

int operacao = int.Parse(Console.ReadLine());

double valorA, valorB;

Console.WriteLine("Dite os valores para ser calculado:");

valorA= double.Parse(Console.ReadLine());
valorB= double.Parse(Console.ReadLine());   

if(operacao == 1)
{
    Console.WriteLine($"Resultado = {valorA + valorB}");
}
else if(operacao == 2)
{
    Console.WriteLine($"Resultado = {valorA - valorB}");

}

else if(operacao == 3)
{
    Console.WriteLine($"Resultado = {valorA / valorB}");
}
else if (operacao == 4)
{
    Console.WriteLine($"Resultado = {valorA * valorB}");
}
else
{
    Console.WriteLine("Opção inválida");
}