using EventPlus.Context;
using EventPlus.Domains;
using EventPlus.Interface;

using Microsoft.EntityFrameworkCore;

namespace EventPlus_.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly EventoContext _context;

        public TipoEventoRepository(EventoContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TipoEventos tipoEvento)
        {
            try
            {
                TipoEventos tipoEventoBuscado = _context.TipoEventos.Find(id)!;

                if (tipoEventoBuscado != null)
                {
                    tipoEventoBuscado.TituloTipoEvento = tipoEvento.TituloTipoEvento;
                }

                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public TipoEventos BuscarPorId(Guid id)
        {
            try
            {
                TipoEventos tipoEventoBuscado = _context.TipoEventos.Find(id)!;
                return tipoEventoBuscado;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(TipoEventos novoTipoEvento)
        {
            try
            {
                _context.TipoEventos.Add(novoTipoEvento);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                TipoEventos tipoEventoBuscado = _context.TipoEventos.Find(id)!;

                if (tipoEventoBuscado != null)
                {
                    _context.TipoEventos.Remove(tipoEventoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoEventos> Listar()
        {
            try
            {
                List<TipoEventos> listaDeEventos = _context.TipoEventos.ToList();
                return listaDeEventos;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
