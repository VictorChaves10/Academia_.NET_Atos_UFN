

int nulos, brancos, validos, mediaNulos, mediaBrancos, mediaValidos;

Console.Write("Informe o número de eleitores: ");
int eleitores = int.Parse(Console.ReadLine());


Console.Write("Quantos votos foram nulos: ");
nulos= int.Parse(Console.ReadLine());

Console.Write("Quantos votos foram em brancos: ");
brancos= int.Parse(Console.ReadLine());

Console.Write("Quantos votos foram valídos: ");
validos= int.Parse(Console.ReadLine());


mediaNulos =  nulos * 100 / eleitores;

mediaBrancos = brancos * 100 /  eleitores;

mediaValidos =  validos * 100 / eleitores ;

Console.WriteLine($"\nTotal de votos: Nulos {mediaNulos}%, Brancos {mediaBrancos}%, Válidos {mediaValidos}%");







