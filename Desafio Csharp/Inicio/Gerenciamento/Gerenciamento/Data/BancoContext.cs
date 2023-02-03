using Gerenciamento.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Data
{
    public class BancoContext : DbContext
    {
        //o options passa minhas informções para dentro do Dbcontext 
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<TarefaModel> Tarefas { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
