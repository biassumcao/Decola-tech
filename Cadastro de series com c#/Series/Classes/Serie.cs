using System;
namespace Series
{
    public class Serie : EntidadeBase
    {
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
		private bool Excluido {get; set;}
		private int Temporadas {get; set;}
		private int avaliacao {get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano, int temporadas, int avaliacao)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
			this.Temporadas = temporadas;
			this.Excluido = false;
			this.avaliacao = avaliacao;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
			retorno += "Quantidade de temporadas: " + this.Temporadas + Environment.NewLine;
			retorno += "Avaliacao: " + this.avaliacao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}


        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}

		public Genero getGenero()
        {
			return this.Genero;
        }

		public string getDescricao()
        {
			return this.Descricao;
        }

		public int getAno()
		{
			return this.Ano;
		}

		public int getTemporadas()
		{
			return this.Temporadas;
		}

		public int getAvalicao()
		{
			return this.avaliacao;
		}

		public void Excluir() {
            this.Excluido = true;
        }
		  
    }
}