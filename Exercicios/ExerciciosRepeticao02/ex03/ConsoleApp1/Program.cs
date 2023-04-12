//Fazer um laço (repetição) que fique solicitando números ao usuário. 
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   



using System;

while (true)
{
    int primo = 0;

    Console.Write("Digite o valor: ");
    int x = int.Parse(Console.ReadLine());

    if (x == 0)
    {
        break;
    }


    if (x % 2 == 0)
    {
        if (x == 2)
        {
            Console.WriteLine($"O número {x} é par e é primo!");
        }
        else
        {
            Console.WriteLine($"O número {x} é par e não é primo!");
        }
    }
    else
    {
        for (int i = 1; i <= x; i++)
        {

            if (x % i == 0)
            {
                primo++;
            }

        }

        if (primo > 2)
        {
            Console.WriteLine($"O número {x} é ímpar e não é primo!");
        }
        else
        {
            Console.WriteLine($"O número {x} é ímpar e é primo!");
        }

    }


}


