using Gerenciamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Repositorio
{
   public interface IUsuarioRepositorio
    {
       UsuarioModel ListaPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        public bool Apagar(int id);
    }
}
