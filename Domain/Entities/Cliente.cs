﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

       
        public string Sobrenome { get; set; }

       
        public string Cpf { get; set; }

       
        public string Email { get; set; }

       
        public string Telefone { get; set; }

       
        public string Profissao { get; set; }

      
        public string GrauEscolaridade { get; set; }

       
        public bool Genero { get; set; }

        public DateTime DataNascimento { get; set; }

     
        public string Endereco { get; set; }

       
        public string Uf { get; set; }

      
        public string Nacionalidade { get; set; }
    }
}
