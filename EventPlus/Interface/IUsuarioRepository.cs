using EventPlus.Domains;

namespace EventPlus.Interface
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuarios novoUsuario);
       
        void Deletar(Guid id);
       
        void Atulizar(Guid id,TiposUsuarios tiposUsuarios);
        
        Usuarios BuscarPorId(Guid id);
        
        Usuarios BuscarPorEmailESenha(string email, string senha);
       
        List<TiposUsuarios> Listar();

    }
}
