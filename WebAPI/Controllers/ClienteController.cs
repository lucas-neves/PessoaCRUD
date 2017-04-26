using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ClienteController : ApiController
    {

        [HttpPost]
        public void Criar([FromBody] Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
            {
                throw new ArgumentException("Nome em branco");
            }

            if (string.IsNullOrWhiteSpace(cliente.Endereco))
            {
                throw new ArgumentException("Endereco em branco");
            }

            if (string.IsNullOrWhiteSpace(cliente.Email))
            {
                throw new ArgumentException("Email em branco");
            }

            if (cliente.Nascimento == null)
            {
                throw new ArgumentException("Data em branco");
            }

            if (cliente.Peso <= 0.0)
            {
                throw new ArgumentException("Peso inválido");
            }

            // Cria o registro no banco de dados
        }


        public void Excluir(int id)
        {
            
        }

        [HttpGet]
        public List<Cliente> Pesquisar(string nome, int id)
        {

            // Obtém os registros do banco de dados com base nos filtros

            Cliente c;

            List<Cliente> clientes = new List<Cliente>();

            c = new Cliente();
            c.Id = 1;
            c.Nome = "Alex";
            c.Endereco = "Rua da rua";
            clientes.Add(c);

            c = new Cliente();
            c.Id = 2;
            c.Nome = "Maria";
            c.Endereco = "Rua da rua 4";
            clientes.Add(c);


            c = new Cliente();
            c.Id = 3;
            c.Nome = "Joao";
            c.Endereco = "Rua da rua 3";
            clientes.Add(c);


            return clientes;
        }

    }
}