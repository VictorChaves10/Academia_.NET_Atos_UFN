


double n1, n2, media;

Console.WriteLine("Digite suas duas notas: ");
n1 = double.Parse(Console.ReadLine());
n2= double.Parse(Console.ReadLine());

media = (n1 + n2) / 2;

if(media >= 7.00)
{
    Console.WriteLine("Aprovado");

}
else
{
    Console.WriteLine("Reprovado");
}