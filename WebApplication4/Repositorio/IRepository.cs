using WebApplication4.Model;

namespace WebApplication4.Repositorio
{
    public interface IRepository
    {
        Task CreateAsync(Usuario model);
        Task GetAsync(Usuario model);
    }
}
