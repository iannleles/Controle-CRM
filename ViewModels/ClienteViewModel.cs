using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleCRM.ViewModels
{
    public class ClienteViewModel
    {
        [MaxLength(50, ErrorMessage = "O campo Nome não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [MaxLength(50, ErrorMessage = "O campo Sobrenome não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo Sobrenome é obrigatório")]
        public string Sobrenome { get; set; }

        [MaxLength(11, ErrorMessage = "O campo CPF não pode ter mais de 11 caracteres")]
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        public  string Cpf { get; set; }

        [MaxLength(50, ErrorMessage = "O Email não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }

        [MaxLength(10, ErrorMessage = "O campo Telefone não pode ter mais de 10 caracteres")]
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        public string Telefone { get; set; }

        [MaxLength(50, ErrorMessage = "O campo Profissão não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo Profissão é obrigatório")]
        public string Profissao { get; set; }

        [MaxLength(20, ErrorMessage = "O campo Grau de escolaridade não pode ter mais de 20 caracteres")]
        [Required(ErrorMessage = "O campo Grau de escolaridade é obrigatório")]
        public string GrauEscolaridade { get; set; }

        [MaxLength(10, ErrorMessage = "O campo Genero não pode ter mais de 10 caracteres")]
        [Required(ErrorMessage = "O campo Genero é obrigatório")]
        public bool Genero { get; set; }

        [MaxLength(11, ErrorMessage = "O campo Data não pode ter mais de 11 caracteres")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [MaxLength(50, ErrorMessage = "O campo Endereço não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Endereco { get; set; }

        [MaxLength(3, ErrorMessage = "O campo UF não pode ter mais de 3 caracteres")]
        [Required(ErrorMessage = "O campo UF é obrigatório")]
        public string Uf { get; set; }

        [MaxLength(10, ErrorMessage = "O campo Nacionalidade não pode ter mais de 10 caracteres")]
        [Required(ErrorMessage = "O campo Nacionalidade é obrigatório")]
        public string Nacionalidade { get; set; }


    }
}