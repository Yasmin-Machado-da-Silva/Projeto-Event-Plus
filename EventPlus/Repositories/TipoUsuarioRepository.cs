using EventPlus.Context;
using EventPlus.Domains;
using EventPlus.Interface;

namespace EventPlus_.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly EventoContext _context;
        public TipoUsuarioRepository(EventoContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TiposUsuarios tipoUsuario)
        {
            try
            {
                TiposUsuarios tipoUsuarioBuscado = _context.TiposUsuarios.Find(id)!;

                if (tipoUsuarioBuscado != null)
                {
                    tipoUsuarioBuscado.TituloTipoUsuario = tipoUsuario.TituloTipoUsuario;
                }

                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public TiposUsuarios BuscarPorId(Guid id)
        {
            try
            {
                TiposUsuarios tipoUsuarioBuscado = _context.TiposUsuarios.Find(id)!;
                return tipoUsuarioBuscado;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(TiposUsuarios novoTipoUsuario)
        {
            try
            {
                _context.TiposUsuarios.Add(novoTipoUsuario);

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
                TiposUsuarios tipoUsuarioBuscado = _context.TiposUsuarios.Find(id)!;

                if (tipoUsuarioBuscado != null)
                {
                    _context.TiposUsuarios.Remove(tipoUsuarioBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TiposUsuarios> Listar()
        {
            try
            {
                List<TiposUsuarios> listaDeUsuarios = _context.TiposUsuarios.ToList();
                return listaDeUsuarios;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
