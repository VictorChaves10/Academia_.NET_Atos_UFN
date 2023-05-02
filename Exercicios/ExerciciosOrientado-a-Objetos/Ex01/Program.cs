

//•1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao. Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados. Esses valores devem ser solicitados ao usuário, por linha de execução.




using Ex01;

Carro car1 = new Carro();
Carro car2 = new Carro();


Console.Write("Digite a marca do carro : ");
car1.Marca = Console.ReadLine();

Console.Write("Digite o modelo do carro: ");
car1.Modelo = Console.ReadLine();

Console.Write("Digite o ano do carro: ");
car1.AnoFabricacao = int.Parse(Console.ReadLine());

Console.WriteLine("\nDigite os dados no outro veiculo: \n");

Console.Write("Digite a marca do carro: ");
car2.Marca = Console.ReadLine();

Console.Write("Digite o modelo do carro: ");
car2.Modelo = Console.ReadLine();

Console.Write("Digite o ano do carro: ");
car2.AnoFabricacao = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine(car1);
Console.WriteLine(car2);


