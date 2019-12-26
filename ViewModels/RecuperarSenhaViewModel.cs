using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleCRM.ViewModels
{
    public class RecuperarSenhaViewModel
    {
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }
    }
}