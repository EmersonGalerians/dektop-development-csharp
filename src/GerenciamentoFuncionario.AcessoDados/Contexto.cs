using GerenciamentoFuncionario.Comuns.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.AcessoDados
{
    class Contexto
    {
        public Contexto() {
            Cargos = new List<Cargo> {
                new Cargo (1, "Desenvolvedor"),
                new Cargo (1, "Engenheiro"),
                new Cargo (1, "Arquiteto"),
                new Cargo (1, "Gerente de Projetos")
            };
        }
        public List<Cargo> Cargos { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
    }
}
