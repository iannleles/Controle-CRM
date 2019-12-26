using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleCRM.ViewModels
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Sobrenome é obrigatório")]
        public string Sobrenome { get; set; }

        [MaxLength(11, ErrorMessage = "O CPF não pode ter mais de 11 caracteres")]
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        public  string Cpf { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Profissão é obrigatório")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "O campo Grau de escolaridade é obrigatório")]
        public string GrauEscolaridade { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório")]
        public bool Genero { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "O campo Nacionalidade é obrigatório")]
        public string Nacionalidade { get; set; }


    }
}