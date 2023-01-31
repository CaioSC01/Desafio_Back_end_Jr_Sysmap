using Gerenciamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Repositorio
{
   public interface ITarefaRepositorio
    {
        TarefaModel ListaPorId(int id);
        List<TarefaModel> BuscarTodos();
        TarefaModel Adicionar(TarefaModel tarefa);
        TarefaModel Atualizar(TarefaModel tarefa);
        public bool Apagar(int id);
    }
}
