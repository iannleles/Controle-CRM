using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleCRM.ViewModels
{
    public class LoginViewModel
    {
        [MaxLength(50, ErrorMessage = "O campo Email não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }

        [MaxLength(15, ErrorMessage = "O campo senha não pode ter mais de 15 caracteres")]
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}