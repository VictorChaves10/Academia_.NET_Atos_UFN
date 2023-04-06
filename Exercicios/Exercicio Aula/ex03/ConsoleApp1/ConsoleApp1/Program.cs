
using System;




Console.Write("Informe a altura do triângulo: ");
double altura = double.Parse(Console.ReadLine());

Console.Write("Informe o valor da base do triângulo: ");
double basee = double.Parse(Console.ReadLine());

if(altura == 0 || basee == 0)
{
    Console.WriteLine("valor inválido");
}

double area = altura * basee / 2 ;

Console.WriteLine("Area do triângulo: "+area.ToString("F2"));

