using EventPlus.Domains;

namespace EventPlus.Interface
{
    public interface IPresencaRepository
    {
        void Deletar(Guid id);
        
        Presenca BuscarPorId(Guid id);

        void Atualizar(Guid id, Presenca presenca);

        List<Presenca> Listar();

        List<Presenca> ListarMinhasPresencas(Guid id);

        void Inscrever(Presenca inscreverPresenca);

    }
}
