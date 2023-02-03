using Gerenciamento.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Models
{
    public class UsuarioSemSenhaModel
    {
        public int id { get; set; }
       [Required(ErrorMessage ="Digite o Nome do Usuario")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do usuario ")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Digite o Email do usuario")]
        [EmailAddress(ErrorMessage ="Email informado não é valido")]
        public string Email { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        [Required(ErrorMessage = "Informe a função do usuario")]
        public int? Funcao {get;set; }
    }
}
