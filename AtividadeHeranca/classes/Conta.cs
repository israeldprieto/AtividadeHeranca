using System;
namespace AtividadeHeranca.classes
{
     class Conta
    {
        public int Nconta { get; set; }
        public string Agencia { get; set; }
        public string NomeTit { get; set; }
        public double Saldo { get; set; }

        public Conta(int nconta, double saldo, string agencia, string nomeTit)
        {
            Saldo = 0;
            Agencia = agencia;
            Nconta = nconta;
            NomeTit = nomeTit;
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
                Console.WriteLine($"Depósito de r$ {valor} realizado com sucesso.");
        }
        public Conta(int nConta, string agencia, string nometit, double saldo)
        {
            Nconta = nConta;
            Agencia = agencia;
            NomeTit = nometit;
            Saldo = saldo;
        }

        public virtual void Saque(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque");
                
            }
        }
        public double GetSaldo()
        {
            return Saldo;
        }

    }
}
