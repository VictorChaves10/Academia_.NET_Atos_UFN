

int medidaEntrada, medidaSaida;
double result, valorEntrada;

Console.WriteLine("\n(1)Metros\n(2)Centímetros\n(3)Polegadas\n(4)Pés");
Console.Write("Selecione a unidade de medida de entrada: ");
medidaEntrada = int.Parse(Console.ReadLine());


Console.Write("Informe a medida de saída: ");
medidaSaida = int.Parse(Console.ReadLine());

Console.Write("Informe o valor a ser convertido: ");
valorEntrada = double.Parse(Console.ReadLine());

switch (medidaEntrada)
{
    case 1:
        switch (medidaSaida)
        {

            case 2:
                result = valorEntrada / 100;
                Console.WriteLine("Conversão: " + result);
                break;
            case 3:
                result = valorEntrada / 0.0254;
                Console.WriteLine("Conversão: " + result.ToString("F2"));
                break;
            case 4:
                result = valorEntrada / 0.3048;
                Console.WriteLine("Conversão: " + result.ToString("F2"));
                break;
            default:
                Console.WriteLine(valorEntrada);
                break;
        }
        break;

    case 2:
        switch (medidaSaida)
        {

            case 1:
                result = valorEntrada * 100;
                Console.WriteLine("Conversão: " + result);
                break;
            case 3:
                result = valorEntrada / 2.54;
                Console.WriteLine("Conversão: " + result.ToString("F2"));
                break;
            case 4:
                result = valorEntrada / 30.48;
                Console.WriteLine("Conversão: " + result.ToString("F2"));
                break;
            default:
                Console.WriteLine(valorEntrada);
                break;
        }
        break;
    case 3:
        switch (medidaSaida)
        {

            case 1:
                result = valorEntrada * 0.0254;
                Console.WriteLine("Conversão: " + result);
                break;
            case 2:
                result = valorEntrada * 2.54;
                Console.WriteLine("Conversão: " + result.ToString("F2"));
                break;
            case 4:
                result = valorEntrada / 12;
                Console.WriteLine("Conversão: " + result.ToString("F2"));
                break;
            default:
                Console.WriteLine(valorEntrada);
                break;
        }
        break;
    case 4:
        switch (medidaSaida)
        {
            case 1:
                result = valorEntrada * 0.3048;
                Console.WriteLine("Conversão: " + result);
                break;
            case 2:
                result = valorEntrada * 30.48;
                Console.WriteLine("Conversão: " + result.ToString("F2"));
                break;
            case 3:
                result = valorEntrada * 12;
                Console.WriteLine("Conversão: " + result.ToString("F2"));
                break;
            default:
                Console.WriteLine(valorEntrada);
                break;
        }
        break;
}
