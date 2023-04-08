



Console.Write("Informe o placar do jogo: ");
string[] placar = Console.ReadLine().Split('x');
int house = int.Parse(placar[0]);
int fora = int.Parse(placar[1]);

if ((house - fora) >= 2)
{
    Console.WriteLine("Os dois times irão se enfrentar novamente em um novo jogo");
    Console.Write("\nInforme o placar do jogo: ");
     placar = Console.ReadLine().Split('x');
     house = int.Parse(placar[0]);
     fora = int.Parse(placar[1]);
    if(house > fora)
    {
        Console.WriteLine("O time da casa se classificou!");
    }
    else
    {
        Console.WriteLine("O time de fora se classificou");
    }
}
else
{
    Console.WriteLine("O time de fora já se classificou");

}
