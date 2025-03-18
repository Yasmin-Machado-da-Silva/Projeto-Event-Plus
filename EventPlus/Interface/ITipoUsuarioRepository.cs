using EventPlus.Domains;

namespace EventPlus.Interface
{
    public interface ITipoUsuarioRepository
    {
        void Cadastrar(TiposUsuarios tipoUsuario);

        List<TiposUsuarios> Listar();

        void Atualizar(Guid id, TiposUsuarios tiposUsuarios);

        void Deletar(Guid id);

        TiposUsuarios BuscarPorId(Guid id);
    }
}