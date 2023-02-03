using Gerenciamento.Data;
using Gerenciamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public UsuarioModel ListaPorId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.id == id);
        }
        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {

            // gravando no banco de dados
            usuario.Dt_Criacao = DateTime.Now;
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDb = ListaPorId(usuario.id);
            if (usuarioDb == null) throw new System.Exception("Houve um erro ao atualizar o Usuario");
            usuarioDb.Nome = usuario.Nome;
            usuarioDb.Login = usuario.Login;
            usuarioDb.Email= usuario.Email;
            usuarioDb.Dt_Nascimento = usuario.Dt_Nascimento;
            usuarioDb.Dt_Atualizacao = DateTime.Now;
            usuarioDb.Funcao = usuario.Funcao;
            _bancoContext.Usuarios.Update(usuarioDb);
            _bancoContext.SaveChanges();

            return usuarioDb;
        }

        public bool Apagar(int id)
        {

            UsuarioModel usuarioDb = ListaPorId(id);
            if (usuarioDb == null) throw new System.Exception("Houve um erro ao apagar");
            _bancoContext.Usuarios.Remove(usuarioDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
