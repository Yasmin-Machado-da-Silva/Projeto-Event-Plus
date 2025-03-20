using EventPlus.Context;
using EventPlus.Domains;
using EventPlus.Interface;
using EventPlus.Utils;

namespace EventPlus.Repositories
{
    namespace api_filmes_senai.Repositories
    {
        public class UsuarioRepository : IUsuarioRepository
        {
            private readonly EventoContext _context;

            public UsuarioRepository(EventoContext Context)
            {
                _context = Context;
            }

            public void Atulizar(Guid id, TiposUsuarios tiposUsuarios)
            {
                throw new NotImplementedException();
            }

            public Usuarios BuscarPorEmailESenha(string email, string senha)
            {
                Usuarios usuarioBuscado = _context.Usuarios.FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha)!;

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }

            public Usuarios BuscarPorId(Guid id)
            {
                try
                {
                    Usuarios usuarioBuscado = _context.Usuarios.Find(id)!;

                    if (usuarioBuscado != null)
                    {
                        return usuarioBuscado;
                    }
                    return null!;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void Cadastrar(Usuarios novoUsuario)
            {
                try
                {
                    novoUsuario.Senha = Criptografia.GerarHash(novoUsuario.Senha);



                    _context.Usuarios.Add(novoUsuario);

                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void Cadastro(Usuarios novoUsuario)
            {
                throw new NotImplementedException();
            }

            public void Deletar(Guid id)
            {
                throw new NotImplementedException();
            }

            public List<TiposUsuarios> Listar()
            {
                throw new NotImplementedException();
            }

            Usuarios IUsuarioRepository.BuscarPorEmailESenha(string email, string senha)
            {
                throw new NotImplementedException();
            }

            Usuarios IUsuarioRepository.BuscarPorId(Guid id)
            {
                throw new NotImplementedException();
            }
        }
    }
}

