namespace Series.Web
{
    public class SerieModel
    {
		public int Id { get; set; }
		public Genero Genero { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public int Ano { get; set; }
		public bool Excluido { get; set; }
		public int Temporadas { get; set; }
		public int Avaliacao { get; set; }

        public SerieModel(Serie serie)         
        {
			Id = serie.Id;
			Genero = serie.getGenero();
			Titulo = serie.retornaTitulo();
			Descricao = serie.getDescricao();
			Ano = serie.getAno();
			Excluido = serie.retornaExcluido();
			Temporadas = serie.getTemporadas();
			Avaliacao = serie.getAvalicao();

		}                                                   //adapter

		public Serie ToSerie()
        {
			return new Serie(Id, Genero, Titulo, Descricao, Ano, Temporadas, Avaliacao);
        }
	}
}
