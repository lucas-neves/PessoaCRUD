using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using System.Data.SqlClient;
using System.Data;

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

            using (SqlConnection conn = new SqlConnection("Server=tcp:programacaoweb.database.windows.net,1433;Database=programacaoweb;User ID=alunos@programacaoweb;Password=web1234$;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                // Cria um comando para inserir um novo registro à tabela
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbPessoa (Nome, Endereco, Email, Nascimento, Peso) VALUES (@nome, @endereco, @email, @nascimento, @peso)", conn))
                {
                    // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@nascimento", cliente.Nascimento);
                    cmd.Parameters.AddWithValue("@peso", cliente.Peso);

                    cmd.ExecuteNonQuery();
                }
            }             
              
        }

        /*
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
        */

    }
}