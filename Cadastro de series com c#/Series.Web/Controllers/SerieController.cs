using Microsoft.AspNetCore.Mvc;
using Series.Interfaces;
namespace Series.Web.Controllers
{
    [Route("[controller]")]
    public class SerieController : Controller
    {
        private readonly IRepositorio<Serie> _repositorioSerie;

        public SerieController(IRepositorio<Serie> repositorioSerie)        //injecao de dependencia : tira dependencia do controller pela implementacao do repositorio
        {
            _repositorioSerie = repositorioSerie;
        }


        [HttpGet("")]
        public IActionResult Lista()
        {
            return Ok(_repositorioSerie.Lista().Select(s => new SerieModel(s))); //retorno padrao : indica se a requisicao funcionou
        }

        [HttpPut("{Id}")] //-> metodo e rota
        public IActionResult Atualiza(int Id, [FromBody] SerieModel model)
        {
            _repositorioSerie.Atualiza(Id, model.ToSerie()); //AutoMapper
            return NoContent();
        }

        [HttpDelete("{Id}")] 
        public IActionResult Exclui(int Id)
        {
            _repositorioSerie.Exclui(Id);
            return NoContent();
        }

        [HttpPost("{Id}")]
        public IActionResult Insere([FromBody] SerieModel model)
        {
            Serie serie = model.ToSerie();
            _repositorioSerie.Insere(serie);
            return Created("", serie);
        }

        [HttpGet("{Id}")] 
        public IActionResult Consulta(int Id)
        {
            return Ok(_repositorioSerie.Lista().FirstOrDefault(s => s.Id == Id));
        }
    }
}
