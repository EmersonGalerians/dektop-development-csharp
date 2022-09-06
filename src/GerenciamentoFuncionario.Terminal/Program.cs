using Gerenciamento_Funcionario.AcessData;
using System;

namespace GerenciamentoFuncionario.Terminal
{
    class Program
    {
        static void Main()
        {
            var provedorFuncionario = new FuncionarioProvedorDados();
            var funcionarios = provedorFuncionario.CarregaFuncionarios();

            foreach (var funcionario in funcionarios) {
                Console.WriteLine($"{funcionario.Id} {funcionario.NomeCompleto}");
                Console.WriteLine("\n\n");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
