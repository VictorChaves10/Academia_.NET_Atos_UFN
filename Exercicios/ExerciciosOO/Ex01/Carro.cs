using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Carro
    {
        public string Marca, Modelo;
        public int AnoFabricacao;



        public void Exibe()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo} e Ano de Fabricação: {AnoFabricacao}");
        }

        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo} e Ano de Fabricação: {AnoFabricacao}";
        }
    }

}    

