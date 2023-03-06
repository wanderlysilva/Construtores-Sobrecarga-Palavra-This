using System.Globalization;

namespace ExercicioProperties_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            Conta ct = new Conta(numero, titular);

            Console.Write("Haverá depósito inicial? S/N: ");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ct.Deposito(depositoInicial);

                Console.WriteLine();
                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine(ct);
            }
            else
            {
                Console.WriteLine("Dados da Conta: " + ct);
            }

            Console.WriteLine();
            Console.WriteLine("Digite a operação que deseja realizar: ");
            Console.Write("Sacar - Depositar S/D: ");
            ch = char.Parse(Console.ReadLine());

            if ( ch == 'd') {
                Console.Write("Digite o vaor do depósito: ");
                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                ct.Deposito(deposito);
                Console.WriteLine("Dados da conta atualizado: " + ct);
            }
            else
            {
                Console.Write("Digite o valor para saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ct.Sacar(saque);
                Console.WriteLine("Dados da conta atualizado: " + ct);
            }
            
        }
    }
}