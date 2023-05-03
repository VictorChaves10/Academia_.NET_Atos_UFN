using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Computador
    {
        public string Marca, Modelo, Tipo;
        public double Preco;

        public Computador(string tipo, string marca,string modelo,  double preco)
        {
            Marca= marca;
            Modelo= modelo;
            Tipo= tipo; 
            Preco = preco;

        }

        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Tipo: {Tipo}, Preco: R${Preco.ToString("F2")}";
        }
    }
}
