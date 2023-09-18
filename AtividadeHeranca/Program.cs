using AtividadeHeranca.classes;

class Program
{
    static void Main(string[] args)
    {
        ContaEmpresa contax = new ContaEmpresa(23456, "Sicoob", "Tecna", 10000.0, 100.0, 5000.0);
        ContaEstudante contay = new ContaEstudante(98765, "Itau", "Bernardo", 500.0, 1000.0, "" +
            "452800182", "IFRO");

        contax.Deposito(2000.0);
        contax.Saque(8000.0);
        contax.RealizarEmprestimo(3000.0);

        contay.Deposito(300.0);
        contay.Saque(800.0);
    }
}
