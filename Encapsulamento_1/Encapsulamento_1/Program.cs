namespace Encapsulamento_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.ToString());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}