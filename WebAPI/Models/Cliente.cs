using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public DateTime Nascimento { get; set; }

        public float Peso { get; set; }
    }

}