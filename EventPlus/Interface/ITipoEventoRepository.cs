using EventPlus.Domains;

namespace EventPlus.Interface
{
    public interface ITipoEventoRepository
    {
        List<TipoEventos> Listar();
            
        void Cadastrar(TipoEventos novoTipoEventos);
            
        void Atualizar(Guid id, TipoEventos tipoEventos);
            
        void Deletar(Guid id);
            
        TipoEventos BuscarPorId(Guid id);
        
    }
}
