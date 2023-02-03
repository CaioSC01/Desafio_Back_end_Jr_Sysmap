using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login do usuario ")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digitea Senha do usuario ")]
        public string Senha { get; set; }
    }
}
