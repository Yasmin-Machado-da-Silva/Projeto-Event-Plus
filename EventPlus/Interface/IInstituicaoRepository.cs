using System.ComponentModel.DataAnnotations;
using EventPlus.Domains;

namespace EventPlus.Interface
{
    public interface IInstituicaoRepository
    {
        void Inscrever (Instituicao inscreverInstituicao);
        
        void Deletar(Guid id);
        
        void Atualizar (Guid id, Instituicao presenca);

        List<Instituicao> Listar();

        List<Instituicao> ListarMinhasInstituicoes(Guid id);

        Instituicao BuscarPorId (Guid id);

    }
}
