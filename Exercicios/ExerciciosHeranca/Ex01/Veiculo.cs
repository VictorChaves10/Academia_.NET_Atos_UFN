

namespace Ex01
{
    internal class Veiculo
    {
        public string Modelo { get; set; }
        public double Potencia { get; set; }

        public void Dirigir()
        {
            Console.WriteLine($"{Modelo}");
        }
    }
}
