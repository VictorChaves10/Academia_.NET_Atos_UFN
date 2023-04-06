

double valorCombustivel = 6.90;
int kmInicial, kmFinal, gasolina;

Console.Write("Informe a quilometragem inicial do veículo: ");
kmInicial = int.Parse(Console.ReadLine());

Console.Write("Informe a quilometragem final do veículo: ");
kmFinal = int.Parse(Console.ReadLine());

Console.Write("Informe quantos litros de combustível foi gasto: ");
gasolina= int.Parse(Console.ReadLine());

Console.Write("Informe o valor ganho pelos clientes: ");
double valorGanho = double.Parse(Console.ReadLine());

int kmRodados =  kmFinal - kmInicial;

int consumo = kmRodados / gasolina;

double lucro = valorGanho - (gasolina * valorCombustivel);

Console.WriteLine($"O consumo do seu veículo é: {consumo}Km/l, o seu lucro do dia foi de: {lucro.ToString("F2")}");

Console.ReadLine();





