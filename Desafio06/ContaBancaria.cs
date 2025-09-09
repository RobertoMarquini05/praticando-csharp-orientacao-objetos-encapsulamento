using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }

        private double saldo;

        // Propriedade somente leitura
        public double Saldo
        {
            get { return saldo; }
        }

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            saldo = saldoInicial;
        }

        public void Sacar(double valor)
        {
            SegurancaConta seguranca = new SegurancaConta();

            if (seguranca.ValidarSaque(valor) && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saque negado pela política de segurança.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}
