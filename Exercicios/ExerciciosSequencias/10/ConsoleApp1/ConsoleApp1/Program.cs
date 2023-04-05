



double notas100 = 0;

Console.Write("Digite o valor que deseja sacar (Notas disponíveis: 100,00 * 50,00 * 20,00 * 10,00): ");

double saque = double.Parse(Console.ReadLine());


if (saque >= 100.00)
{
    for (int i = 1; i * 100.00 <= saque; i++)
    {
        notas100 = i * 100.00;
        Console.WriteLine("R$ 100.00");
    }
  
}

if(saque - notas100 == 90.00)
{
    Console.WriteLine("R$ 50.00");
    Console.WriteLine("R$ 20.00");
    Console.WriteLine("R$ 20.00");
}

else if (saque - notas100 == 80.00)
{
    Console.WriteLine("R$ 50.00");
    Console.WriteLine("R$ 20.00");
    Console.WriteLine("R$ 10.00");
}

else if (saque - notas100 == 70.00)
{
    Console.WriteLine("R$ 50.00");
    Console.WriteLine("R$ 20.00");
}

else if (saque - notas100 == 60.00)
{
    Console.WriteLine("R$ 50.00");
    Console.WriteLine("R$ 10.00");
}
else if (saque - notas100 == 50.00)
{
    Console.WriteLine("R$ 50.00");
}
else if (saque - notas100 == 40.00)
{
    Console.WriteLine("R$ 20.00");
    Console.WriteLine("R$ 20.00");
}
else if (saque - notas100 == 30.00)
{
    Console.WriteLine("R$ 20.00");
    Console.WriteLine("R$ 10.00");
}
else if (saque - notas100 == 20.00)
{
    Console.WriteLine("R$ 20.00");
   
}
else if (saque - notas100 == 10.00)
{
    Console.WriteLine("R$ 10.00");

}


//if (saque % 100.00 >= 50.00)
//{
//    Console.WriteLine("R$: 50.00");
//}
//if (saque % 50.00 >= 40.00)
//{
//    Console.WriteLine("R$: 40.00");
//}
//else if (saque % 50.00 >= 20.00)
//{
//    Console.WriteLine("R$: 20.00");
//}

//if(saque % 30.00 <= 10.00 && saque % 50.0 > 40.00 && saque % 50.00 != 50.00)
//{
//    Console.WriteLine("R$: 10.00");
//}
