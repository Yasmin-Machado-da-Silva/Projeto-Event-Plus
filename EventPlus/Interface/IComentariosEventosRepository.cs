using EventPlus.Domains;

namespace EventPlus.Interface
{
    public interface IComentariosEventosRepository
    {
        void Cadastrar(ComentarioEventos comentarioEventos);
        void Deletar(Guid idComentario);
        List<ComentarioEventos> Listar();
        ComentarioEventos BuscarPorIdUsuario(Guid UsuarioId, Guid EventosId);
    }
}
