namespace Properties_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Produto produto = new Produto("TV", 500.00, 10);

            produto.Nome = "TV 4K";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);
        }
    }
}