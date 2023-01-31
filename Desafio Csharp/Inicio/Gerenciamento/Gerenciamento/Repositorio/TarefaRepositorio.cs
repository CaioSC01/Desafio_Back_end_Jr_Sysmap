using Gerenciamento.Data;
using Gerenciamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly BancoContext _bancoContext;
        public TarefaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public TarefaModel ListaPorId(int id)
        {
            return _bancoContext.Tarefas.FirstOrDefault(x => x.id == id);
        }
        public List<TarefaModel> BuscarTodos()
        {
            return _bancoContext.Tarefas.ToList();
        }
        public TarefaModel Adicionar(TarefaModel tarefa)
        {
            // gravando no banco de dados
            _bancoContext.Tarefas.Add(tarefa);
            _bancoContext.SaveChanges();
            return tarefa;
        }

        public TarefaModel Atualizar(TarefaModel tarefa)
        {
            TarefaModel tarefaDb = ListaPorId(tarefa.id);
            if (tarefaDb == null) throw new System.Exception("Houve um erro ao atualizar a Descrição");
            tarefaDb.Descricao = tarefa.Descricao;
            tarefaDb.Data_Hora = tarefa.Data_Hora;

            _bancoContext.Tarefas.Update(tarefaDb);
            _bancoContext.SaveChanges();

            return tarefaDb;
        }

        public bool Apagar(int id)
        {

            TarefaModel tarefaDb = ListaPorId(id);
            if (tarefaDb == null) throw new System.Exception("Houve um erro ao apagar");
            _bancoContext.Tarefas.Remove(tarefaDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
