using ConstrutoresCSharp_2;
using System.Globalization;

namespace ConstrutoresCSharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}