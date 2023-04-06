namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            string nome;
            double salario,totalVendas;

            Console.Write("Informe o seu código: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("\nInforme seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\nInforme o seu salário base: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o total de vendas: ");
            totalVendas = double.Parse(Console.ReadLine());


            if(totalVendas > 500.00 && totalVendas <= 1000.00)
            {
                double salarioFinal = (totalVendas * 5.00 / 100.00) + salario;
                Console.WriteLine($"Nome: {nome}, código: {codigo}, salário inicial: {salario.ToString("f2")}, salário + comissão: {salarioFinal.ToString("F2")} ");
            }
            else if(totalVendas > 1000.00 && totalVendas <= 5000.00)
            {
                double salarioFinal = (totalVendas * 7.00 / 100.00) + salario;
                Console.WriteLine($"Nome: {nome}, código: {codigo}, salário inicial: {salario.ToString("f2")}, salário + comissão: {salarioFinal.ToString("F2")} ");
            }
            else if (totalVendas > 5000.00)
            {
                double salarioFinal = (totalVendas * 10.00 / 100.00) + salario;
                Console.WriteLine($"Nome: {nome}, código: {codigo}, salário inicial: {salario.ToString("f2")}, salário + comissão: {salarioFinal.ToString("F2")} ");
            }
            else
            {
                
                Console.WriteLine($"Nome: {nome}, código: {codigo}, salário inicial: {salario.ToString("f2")}, salário + comissão: {salario.ToString("F2")} ");
            }
        }
    }
}