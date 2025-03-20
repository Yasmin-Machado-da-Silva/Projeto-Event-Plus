using EventPlus.Context;
using EventPlus.Domains;
using EventPlus.Interface;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ap.Repositories
{
    public class PresencaRepository : IPresencaRepository

    {
        private readonly EventoContext _context;
        public PresencaRepository(EventoContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Presenca presenca)
        {
            throw new NotImplementedException();
        }

        public Presenca BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Inscrever(Presenca inscreverPresenca)
        {
            throw new NotImplementedException();
        }

        public List<Presenca> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Presenca> ListarMinhasPresencas(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}


       