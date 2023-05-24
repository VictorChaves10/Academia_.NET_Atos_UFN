

namespace Ex01
{
    internal class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo}");
        }
    }
}
