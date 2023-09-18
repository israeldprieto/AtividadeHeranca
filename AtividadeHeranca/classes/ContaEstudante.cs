using System;
namespace AtividadeHeranca.classes
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string CPF { get; set; }
        public string InstituicaoEnsino { get; set; }

        public ContaEstudante(int nConta, string agencia, string Nometit, double saldo,
            double limitechequeespecial, string cpf, string instituicaoEnsino)
            : base(nConta, agencia, Nometit, saldo)
        {
            this.LimiteChequeEspecial = limitechequeespecial;
            this.CPF = cpf;
            this.InstituicaoEnsino = instituicaoEnsino;
        }
        public override void Saque(double valor)
        {
            if(Saldo + LimiteChequeEspecial >= valor) 
            {
                if (Saldo >= valor)
                {
                    Saldo -= valor;
                }
                else
                {
                    LimiteChequeEspecial -= (valor - Saldo);
                    Saldo = 0;
                }
                Console.WriteLine($"Saque de r${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo e limite de cheque insuficientes para saque.");
            }
        }
    }
}
