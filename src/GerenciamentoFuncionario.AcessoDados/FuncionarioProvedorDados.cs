using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        private readonly Contexto _contexto;

        public FuncionarioProvedorDados() {
            _contexto = new Contexto();
        }
        public void AtualizaFuncionario(Funcionario funcionarioAtualizado)
        {
            _contexto.Funcionarios.ForEach(f =>
            {
                if (f.Id == funcionarioAtualizado.Id)
                {
                    f.NomeCompleto = funcionarioAtualizado.NomeCompleto;
                    f.SetCargoId(funcionarioAtualizado.CargoId);
                    f.SetBeberCafe(funcionarioAtualizado.EBebedorCafe);
                }
            }



           );
        }

        public void ExcluiFuncionarioPorId(int id)
        {
            var funcionario = RecuperaFuncionarioPorId(id);
            ExcluiFuncionario(funcionario);
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            _contexto.Funcionarios.Remove(funcionario);
        }


        public Funcionario RecuperaFuncionarioPorId(int id)
        {
            //x é tudo e qualquer elemento da lista
            //cada elemento da lista será testado
            //x vai recever o valor do id que você quer pesquisar, ai vai procurar o id na lista
            //return _contexto.Funcionarios.Find(x => x.Id == id);
            //return _contexto.Funcionarios.FirstOrDefault(x => x.Id == id);
            return _contexto.Funcionarios.Where(x => x.Id == id).FirstOrDefault();
        }



        public void SalvaFuncionario(Funcionario funcionario)
        {
            //Debug.WriteLine($"Funcionário salvo: {funcionario.PrimeiroNome}");
            var id = GeradorDeId();
            funcionario.Id = id;
            _contexto.Funcionarios.Add(funcionario);
        }
        private int GeradorDeId()
        {
            //TODO : olhar lista e ve qual é o maior id
            //TODO =  PARA FAZER
            var maiorId = _contexto.Funcionarios.Max(x => x.Id);



            //var temId = true;
            //while (true)
            //{
            //    maiorId++; //maiorId = maiorId + 1
            //    temId = _contexto.Funcionarios.Any(x => x.Id.Equals(maiorId));
            //}
            bool temId;
            do
            {
                maiorId++;
                temId = _contexto.Funcionarios.Any(x => x.Id.Equals(maiorId));
            } while (temId);



            return maiorId;

            //equal -> ==


        }
            public IEnumerable<Funcionario> CarregaFuncionarios()
            {
                return _contexto.Funcionarios;
            }
    }
}
