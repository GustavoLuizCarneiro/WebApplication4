using WebApplication4.Model;
using WebApplication4.Repositorio;

namespace WebApplication4.Servico
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepository _repository;

        public UsuarioService(IRepository repository)
        {
            _repository = repository;
        }

        public async  Task Create(Usuario model)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
