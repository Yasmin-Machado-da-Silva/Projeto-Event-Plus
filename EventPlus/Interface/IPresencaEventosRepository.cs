using EventPlus.Domains;

namespace EventPlus.Interface
{
    public interface IPresencaEventosRepository
    {
        void Deletar(Guid id);
        
        PresencaEventos BuscarPorId(Guid id);

        void Atualizar(Guid id, PresencaEventos presenca);

        List<PresencaEventos> Listar();

        List<PresencaEventos> ListarMinhasPresencas(Guid id);

        void Inscrever(PresencaEventos inscreverPresenca);

    }
}
