using EventPlus.Domains;

namespace EventPlus.Interface
{
    public interface IComentariosEventosRepository
    {
        void Cadastrar(ComentarioEventos comentarioEventos);
        void Deletar(int idComentario);
        List<ComentarioEventos> Listar(Guid id);
        ComentarioEventos BuscarPorIdUsuario(Guid UsuarioId, Guid EventosID);
    }
}
