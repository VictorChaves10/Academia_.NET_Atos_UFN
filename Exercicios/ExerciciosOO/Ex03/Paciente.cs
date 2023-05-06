using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Paciente
    {
        public string Nome;
        public string  Cpf;
        public string DatadeNascimento;
        public string Email;


        public Paciente(string nome, string cpf, string nascimento, string email)
        {
            Nome = nome;
            DatadeNascimento = nascimento;
            Cpf = cpf;
            Email = email;
        }

        public override string ToString()
        {
            return $"\n\n//DADOS DO PACIENTE//\n--------------------------------------------------\n\nNome: {Nome}\nCPF: {Cpf}\nData de nascimento: {DatadeNascimento}\nEmail: {Email}\n\n--------------------------------------------------";
        }

    }
}

