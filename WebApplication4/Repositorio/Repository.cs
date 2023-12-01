using Microsoft.VisualBasic;
using WebApplication4.Model;

namespace WebApplication4.Repositorio
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public Repository(ApplicationDbContext applicationDbContext)
        {
             _applicationDbContext = applicationDbContext;
        }
        public async Task CreateAsync(Usuario model)
        {
            try
            {
                await _applicationDbContext.AddRangeAsync(model);
                await _applicationDbContext.SaveChangesAsync();     
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task GetAsync(Usuario model)
        {
            throw new NotImplementedException();
        }
    }
}
