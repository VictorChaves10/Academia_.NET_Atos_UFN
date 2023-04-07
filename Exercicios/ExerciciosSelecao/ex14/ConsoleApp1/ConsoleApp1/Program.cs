


int mb, mbps, convertSeconds ;

Console.Write("Informe o tamanho do arquivo (MB): ");
mb = int.Parse(Console.ReadLine());

Console.Write("Qual a velocidade do link de internet (mbps): ");
mbps = int.Parse(Console.ReadLine());

convertSeconds = mb / (mbps / 8);

if (convertSeconds > 60)
{
    int convertMinutes = convertSeconds / 60;
    Console.WriteLine($"O tempo de download é de {convertMinutes} min");
}
else {
    Console.WriteLine("O tempo de download é de 0 min");
}


//14 - faça um programa que peça o tamanho de um arquivo para download (em mb) e a velocidade de um 
//link de internet (em mbps). em seguida, calcule e informe o tempo aproximado de download 
//do arquivo usando este link (em minutos).
