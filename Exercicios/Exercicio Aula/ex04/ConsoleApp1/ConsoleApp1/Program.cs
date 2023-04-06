

double n1, n2, n3, n4, media;


Console.WriteLine("Digite quatro valores: ");
n1= double.Parse(Console.ReadLine());
n2= double.Parse(Console.ReadLine());
n3= double.Parse(Console.ReadLine());
n4= double.Parse(Console.ReadLine());   


media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine("Média: "+media);

if(n1 > media)
{

    Console.WriteLine("\nSuperior a média: "+n1);
}
 if(n2 > media)
{
    Console.WriteLine("\nSuperior a média: " + n2);
}
 if(n3 > media)
{
    Console.WriteLine("\nSuperior a média: " + n3);
}
 if (n4 > media)
{
    Console.WriteLine("\nSuperior a média: " + n4);
}    