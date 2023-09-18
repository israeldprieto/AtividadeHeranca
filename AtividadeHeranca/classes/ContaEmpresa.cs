using System;
namespace AtividadeHeranca.classes
{
    internal class ContaEmpresa:Conta
    {
        public double TaxaAnuidade { get; set; }
        public double LimiteEmprestimo { get; set; }    
        public double TotalEmprestimo { get; set; }

        public ContaEmpresa(int nconta, string agencia, string nomeTit, double taxaAnuidade,
            double limiteEmprestimo)
            : base(nconta, agencia, nomeTit)
        {
            TaxaAnuidade = taxaAnuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = 0;
        }

        public void RealizarEmprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo)
            {
                Saldo += valor;
                TotalEmprestimo += valor;
                Console.WriteLine("Empréstimo de r$" + valor + "realizado");
            }
            else
            {
                Console.WriteLine("O valor de empréstimo não pode ser dado");
            }
        }
        public override void Saque(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                if(valor > 5000.0)
                {
                    Saldo -= 5.0;// taxa de saques acima de 5000,00
                }
                Console.WriteLine($"Saque de {valor} realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para saque de {valor}");
            }
        }

    }
}
