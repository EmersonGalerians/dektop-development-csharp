using System;
using GerenciamentoFuncionario.AcessoDados;
using GerenciamentoFuncionario.comuns.Modeleos;
using System.Collections.Generic;
using GerenciamentoFuncionario.Comuns.Modelos;

namespace GerenciamentoFuncionario.Terminal
{
    class Program
    {
        static void Main()
        {
            ApresentaFuncionario(funcionario);

            provedorFuncionario.SalvarFuncionario(new Funcionario("Funlando de Tal", 1, false));
            provedorFuncionario.SalvarFuncionario(new Funcionario("Ciclano de Tal", 2, false));
            provedorFuncionario.SalvarFuncionario(new Funcionario("Beltrano de Tal", 1, false));

            ApresentaFuncionario(funcionario);

            var funcionarioSelecionado = provedorFuncionario.RecuperarFuncionarioPorId(3);

            provedorFuncionario.ExcluirFuncionario(funcionarioSelecionado);

            ApresentarFuncionarios(funcionarios);

            funcionarioSelecionado = provedorFuncionario.RecuperarFuncionarioPorId();

            funcionarioSelecionado.NomeCompleto = "bla bla bla";
            funcionarioSelecionado.NaoEBebedorDeCafe();
            funcionarioSelecionado.SetCargoId();
            funcionarioSelecionado.AtualizarFuncionario(funcionarioSelecionado);

            ApresentarFuncionarios(funcionarios);

        }

        private static void ApresentaFuncionario(object funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
