


Console.Write("Informe as horas: ");
string[] horario = Console.ReadLine().Split(":");

int hora = int.Parse(horario[0]);
int minutos = int.Parse(horario[1]);

if(hora < 24 && hora >= 0)
{
    Console.WriteLine("Hora valida!");
}
else
{
    Console.WriteLine("Hora inválida!");
}
