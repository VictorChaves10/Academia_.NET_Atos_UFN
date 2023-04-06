


int n1, n2, n3;

int mediaGlicemia;

Console.WriteLine("Infome os três valores de glicemia em jejum: ");

n1 = int.Parse(Console.ReadLine());

if(n1 < 65)
{
    Console.WriteLine("Risco de hipoglicemia");
}
else if(n1 > 250)
{
    Console.WriteLine("risco de hiperglicemia.");
}

n2 = int.Parse(Console.ReadLine());

if (n2 < 65)
{
    Console.WriteLine("Risco de hipoglicemia");
}
else if (n2 > 250)
{
    Console.WriteLine("risco de hiperglicemia.");
}

n3 = int.Parse(Console.ReadLine());

if (n3 < 65)
{
    Console.WriteLine("Risco de hipoglicemia");
}
else if (n3 > 250)
{
    Console.WriteLine("risco de hiperglicemia.");
}


mediaGlicemia = (n1 + n2 + n3) / 3;

if(mediaGlicemia < 80)
{
    Console.WriteLine("Diminuir 2 unidades de insulina");
}
else if(mediaGlicemia > 150)
{
    Console.WriteLine("Necessário adicionar 2 unidades de insulina");
}



//9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
//diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
//Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
//Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

//Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
//menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
//150, avisá-lo que será necessário adicionar 2 unidades de insulina.