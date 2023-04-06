namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase, pesquisa;
            Console.Write("Escreva uma frase: ");
            frase = Console.ReadLine();

            Console.Write("Digite a palarava de pesquisa: ");
            pesquisa = Console.ReadLine();

            if (frase.Contains(pesquisa))
            {
                Console.WriteLine("A palavra '" + pesquisa+"', contem na frase.");
            }
            else
            {
                Console.WriteLine("A palavra '" + pesquisa+"', não contem na frase.");
            }
            Console.ReadLine();
        }
    }
}