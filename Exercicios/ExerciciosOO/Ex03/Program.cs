



using ConsoleApp1;

Console.Write("Nome do paciente: ");
string nome = Console.ReadLine();

Console.Write("CPF do paciente: ");
string cpf = Console.ReadLine();

Console.Write("Data de nascimento: ");
string idade = Console.ReadLine();

Console.Write("Informe o E-mail: ");
string email = Console.ReadLine();

Paciente p1 = new Paciente(nome,cpf,idade,email);

Triagem p1Triagem = new Triagem();


Console.WriteLine("\nInforme a região da sua residência:\n\n1- Zona norte\n2- Zona Oeste\n3- Zona Leste \n4- Zona Sul  ");
Console.Write("\nOpção: ");

int posicao = int.Parse(Console.ReadLine());

Console.Write("\nInforme o peso do paciente: ");
p1Triagem.Peso = int.Parse(Console.ReadLine());

Console.Write("Informe a altura: ");
p1Triagem.Altura = double.Parse(Console.ReadLine());

Console.WriteLine("Qual a pressão do paciente: ");
Console.Write(" Sistólica: ");
p1Triagem.PressaoSistolica = int.Parse((Console.ReadLine()));

Console.Write(" Diastólica: ");
p1Triagem.PressaoDiastolica = int.Parse((Console.ReadLine()));

Console.Write("Informe a temperatura do paciente: ");
p1Triagem.Temperatura = double.Parse(Console.ReadLine());



Console.WriteLine(p1);
Console.WriteLine(p1Triagem);





