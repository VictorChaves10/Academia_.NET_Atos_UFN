using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Paciente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public string DataDeNascimento{ get; private set; }


        public Paciente(string nome, string cpf, string nascimento, string email)
        {
            Nome = nome; 
            DataDeNascimento = nascimento;
            Cpf = cpf;
            Email = email;
        }

        public override string ToString()
        {
            return $"\n\n//DADOS DO PACIENTE//\n--------------------------------------------------\n\nNome: {Nome}\nCPF: {Cpf}\nData de nascimento: {DataDeNascimento}\nEmail: {Email}\n\n--------------------------------------------------";
        }

    }
}

