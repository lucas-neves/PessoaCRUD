using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers {
	public class ExemploController : ApiController {
		[HttpGet]
		public List<Pessoa> Obter() {
			return null;
		}

		[HttpPost]
		public void Criar([FromBody] Pessoa pessoa) {
			if (string.IsNullOrWhiteSpace(pessoa.Nome)) {
				throw new ArgumentException("Nome em branco");
			}
			if (pessoa.Idade <= 0) {
				throw new ArgumentException("Idade inválida");
			}
			if (pessoa.Escolhas == null || pessoa.Escolhas.Length == 0) {
				throw new ArgumentException("Escolhas inválidas");
			}

			// Cria o registro no banco de dados
		}

		[HttpGet]
		public Pessoa Obter(int id) {
			// Obtém o registro do banco de dados

			Pessoa p = new Pessoa();
			p.Id = id;
			p.Nome = "Alex";
			p.Sexo = 2;
			p.Idade = 20;
			p.Escolhas = new int[] { 2, 4 };

			return p;
		}

		[HttpGet]
		public List<Pessoa> Pesquisar(string nome, int idade, [FromUri] int[] escolhas) {

			// Obtém os registros do banco de dados com base nos filtros

			Pessoa p;

			List<Pessoa> pessoas = new List<Pessoa>();

			p = new Pessoa();
			p.Id = 1;
			p.Nome = "Alex";
			p.Idade = 20;
			p.Escolhas = new int[] { 2, 4 };
			pessoas.Add(p);

			p = new Pessoa();
			p.Id = 2;
			p.Nome = "Marcos";
			p.Idade = 31;
			p.Escolhas = new int[] { 1 };
			pessoas.Add(p);

			p = new Pessoa();
			p.Id = 3;
			p.Nome = "Álvaro";
			p.Idade = 18;
			p.Escolhas = new int[] { 3 };
			pessoas.Add(p);

			return pessoas;
		}
	}
}
