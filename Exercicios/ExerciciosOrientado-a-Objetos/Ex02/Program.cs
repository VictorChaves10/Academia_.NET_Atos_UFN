//Crie uma classe chamada Computador que possua 4 atributos: marca, modelo, tipo (notebook, netbook, tablet, etc) e preço. Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução. Já, os valores do segundo objeto, deverão ser definidos no código-fonte da classe que o criou. Exiba na tela os resultados.


using Ex02;
using System.Globalization;


Console.Write("Informe o tipo do produto: ");
string tipo = Console.ReadLine();

Console.Write("Informe a marca: ");
string marca = Console.ReadLine();

Console.Write("Informe o modelo: ");
string modelo = Console.ReadLine();

Console.Write("Informe o valor: ");
double preco = double.Parse(Console.ReadLine());

Computador p1 = new Computador(tipo,marca,modelo,preco);

Computador p2 = new Computador("Video Game", "Sony", "Playstation 5", 3500.00);

Console.WriteLine();
Console.WriteLine(p1);
Console.WriteLine();
Console.WriteLine(p2);