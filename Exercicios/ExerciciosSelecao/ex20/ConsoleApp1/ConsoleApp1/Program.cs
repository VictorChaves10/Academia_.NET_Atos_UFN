

Random random = new Random();

int chance = 3;
int numberRandom = random.Next(10);

Console.Write("Informe sua primeira tentativa: ");
int palpite = int.Parse(Console.ReadLine());

while(palpite != numberRandom && chance != 1)
{
    chance--;

    if (palpite > numberRandom)
    {
        Console.WriteLine("É menor!");
    }
    else
    {
        Console.WriteLine("É maior!");
    }

    Console.Write($"Você tem mais {chance} tentativas: ");
    palpite = int.Parse(Console.ReadLine());
}

if (palpite == numberRandom)
{
    Console.WriteLine("Você acertou");
}
else
{
    Console.WriteLine("Suas chances acabaram!");
}
