





double combustivel, distancia, media;


Console.Write("Informe a quantidade (Litros) que foi abastecido: ");

combustivel = double.Parse(Console.ReadLine());

Console.Write("Informe a quantidade (Km) que seu veículo percorreu: ");

distancia= double.Parse(Console.ReadLine());


media =  distancia / combustivel;

Console.WriteLine($"O consumo médio do seu veículo é : {media.ToString("F1")} Km/l");