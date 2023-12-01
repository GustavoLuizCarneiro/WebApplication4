using WebApplication4.Model;

namespace WebApplication4.Servico
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuarios();
        Task Create(Usuario model);
    }
}
