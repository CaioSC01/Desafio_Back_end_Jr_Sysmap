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
    [PaginaAdmin]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();

            return View(usuarios);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _usuarioRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Usuario cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch (System.Exception error)
            {
                TempData["MensagemErro"] = $"Ops não foi possivel cadastrar o contato, tente novamente. detalhe fo erro: {error.Message}";
                return RedirectToAction("Index");
            }
         
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            var usuario = _usuarioRepositorio.ListaPorId(id);
            return View(usuario);
        }
        public IActionResult Apagar(int id)
        {
            try
            {

           bool apagado = _usuarioRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuario Apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Não conseguimos apagar o Usuario";
                }
            return RedirectToAction("Index");
            }
            catch(System.Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos apagar o Usuario, mais detalhes do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Editar(int id)
        {
            var usuario = _usuarioRepositorio.ListaPorId(id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Editar(UsuarioSemSenhaModel usuarioSemSenha)
        {
            try
            {
                UsuarioModel usuario = null;

                if (ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        id = usuarioSemSenha.id,
                        Nome = usuarioSemSenha.Nome,
                        Email = usuarioSemSenha.Email,
                        Login = usuarioSemSenha.Login,
                        Dt_Nascimento = usuarioSemSenha.Dt_Nascimento,
                        Funcao = usuarioSemSenha.Funcao
                   
                    };

                    usuario = _usuarioRepositorio.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Usuario Alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View( usuario);
            }
            catch (System.Exception error)
            {
                TempData["MensagemErro"] = $"Ops não foi possivel alterar o Usuario, tente novamente. detalhe fo erro: {error.Message}";
                return RedirectToAction("Index");
            }

        }
          
         

    }
}
