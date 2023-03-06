
using System.Globalization;

namespace ExercicioProperties_1
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }


        public void Deposito (double deposito)
        {
            Saldo += deposito;
        }

        public void SacarConta (double sacar)
        {
            Saldo -= sacar + 5.00;
        }

        public override string ToString()
        {
            return "Conta : "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
