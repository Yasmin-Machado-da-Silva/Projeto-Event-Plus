using EventPlus.Domains;
using EventPlus.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EventPlus.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ComentariosEventosController : ControllerBase
    {
        private readonly IComentariosEventosRepository _comentariosEventosRepository;

        public ComentariosEventosController(IComentariosEventosRepository comentariosEventosRepository)
        {
            _comentariosEventosRepository = comentariosEventosRepository;
        }

        [Authorize]
        [HttpPost]

        public IActionResult Post(ComentarioEventos novoComentarioEventos)
        {
            try
            {
                _comentariosEventosRepository.Cadastrar(novoComentarioEventos);
                return Created();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid idComentario)
        {
            try
            {
                _comentariosEventosRepository.Deletar(idComentario);
                return NoContent();

            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<ComentarioEventos> listaDeComentarios = _comentariosEventosRepository.Listar();
                return Ok(listaDeComentarios);

            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }

        [HttpGet("BuscarPorIdUsuario/{id}")]
        public IActionResult GetById(Guid UsuarioId, Guid EventosId)
        {
            try
            {
                ComentarioEventos comentarioBuscado = _comentariosEventosRepository.BuscarPorIdUsuario(UsuarioId, EventosId);
                return Ok(comentarioBuscado);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

    }
}
