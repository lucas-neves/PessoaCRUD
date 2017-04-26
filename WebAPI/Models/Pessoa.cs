using System;
using System.Collections.Generic;
using System.Web;

namespace WebAPI.Models {
	public class Pessoa {
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Sexo { get; set; }
		public int Idade { get; set; }
		public int[] Escolhas { get; set; }
	}
}
