using EventPlus.Domains;
using EventPlus.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventPlus.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PresencaController : ControllerBase
    {
        public readonly IPresencaRepository _presencaEventosRepository;
        public PresencaController(IPresencaRepository presencaEventosRepository)
        {
            _presencaEventosRepository = presencaEventosRepository;
        }

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _presencaEventosRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                Presenca presencaBuscada = _presencaEventosRepository.BuscarPorId(id);
                return Ok(presencaBuscada);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [Authorize]
        [HttpPut("id")]

        public IActionResult Put(Guid id, Presenca presenca)
        {
            try
            {
                _presencaEventosRepository.Atualizar(id, presenca);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Presenca> ListaDePresenca = _presencaEventosRepository.Listar();
                return Ok(ListaDePresenca);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public IActionResult Get(Guid id)
        {
            try
            {
                List<Presenca> ListarPresencas= _presencaEventosRepository.ListarMinhasPresencas(id);
                return Ok(ListarPresencas);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [Authorize]
        [HttpPost]

        public IActionResult Post(Presenca inscreverPresencaEventos)
        {
            try
            {
                _presencaEventosRepository.Inscrever(inscreverPresencaEventos);
                return Created();
            }

            catch (Exception error)
            {
                return BadRequest(error.Message);
            }

        }

    }
}