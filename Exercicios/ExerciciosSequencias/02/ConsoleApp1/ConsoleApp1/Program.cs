


Console.WriteLine("Digite abaixo quatro valores: ");

double a, b, c, d, media;

a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
d = double.Parse(Console.ReadLine());

media = (a+b+c+d) / 4 ;

Console.WriteLine("Média: " + media.ToString("F2"));