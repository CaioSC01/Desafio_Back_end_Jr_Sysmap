using Gerenciamento.Filters;
using Gerenciamento.Models;
using Gerenciamento.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Controllers
{
    [PaginaUsuarioLoged]
    public class TarefasController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefasController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        public IActionResult Index()
        {
            var tarefas = _tarefaRepositorio.BuscarTodos();
            return View(tarefas);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
           var tarefas = _tarefaRepositorio.ListaPorId(id);
            return View(tarefas);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            var tarefas = _tarefaRepositorio.ListaPorId(id);
            return View(tarefas);
        }
        public IActionResult Apagar(int id)
        {
            _tarefaRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Criar(TarefaModel tarefa)
        {
            _tarefaRepositorio.Adicionar(tarefa);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Alterar(TarefaModel tarefa)
        {
            _tarefaRepositorio.Atualizar(tarefa);
            return RedirectToAction("Index");
        }
    }
}
