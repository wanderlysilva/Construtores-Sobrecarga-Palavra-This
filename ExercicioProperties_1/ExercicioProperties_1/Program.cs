using System.Globalization;

namespace ExercicioProperties_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            Conta ct = new Conta(numero,titular);


            Console.Write("Haverá depósito inicial? S/N ");
            char ch = char.Parse(Console.ReadLine());

            if(ch ==  's') 
            {
                Console.Write("Digite o vaor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                ct.Deposito(depositoInicial);

                Console.WriteLine("Dados da Conta: " + ct);
            }
            else
            {
                Console.WriteLine("Dados da Conta: " + ct);
            }

            Console.WriteLine();
            Console.Write("Entre com o valor de depósito: ");
            double deposito = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
            ct.Deposito(deposito);

            Console.Write("Dados da conta atualizados: " + ct);

            Console.WriteLine();
            Console.Write("Entre com o valor de saque: ");
            double saque = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            ct.SacarConta(saque);

            Console.WriteLine("Dados da conta atualizados: " + ct);

        }
    }
}