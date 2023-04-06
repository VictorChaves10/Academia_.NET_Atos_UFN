

string nomeMaisculo, nome;
double altura,imc;
int peso;


Console.Write("Informe seu  nome (letras maiúsculas): ");
nome = Console.ReadLine();

nomeMaisculo = nome.ToUpper();

while(nome != nomeMaisculo)
{
    Console.Write("Favor utilizar letras maiúsculas (ex: MARIA): ");
    nome = Console.ReadLine();
    nomeMaisculo = nome.ToUpper();
}

Console.Write("\nQual a sua altura (metros): ");
altura = double.Parse(Console.ReadLine());

Console.Write("\nInforme seu peso (Kg): ");
peso = int.Parse(Console.ReadLine());   

imc = peso / (altura * altura);

if(imc < 18)
{
    Console.WriteLine("Baixo peso");
}
else if (imc < 25)
{
    Console.WriteLine("Peso normal");
}
else if (imc < 30)
{
    Console.WriteLine("Sobrepeso");
}
else if (imc < 35)
{
    Console.WriteLine("Obesidade");
}
else
{
    Console.WriteLine("Obesidade grau sério");
}





