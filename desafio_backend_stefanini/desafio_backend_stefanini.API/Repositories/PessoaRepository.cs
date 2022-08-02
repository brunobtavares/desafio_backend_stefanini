using desafio_backend_stefanini.API.Data;
using desafio_backend_stefanini.API.Interfaces;
using desafio_backend_stefanini.API.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio_backend_stefanini.API.Repositories
{
    public class PessoaRepository : GenericRepository<Pessoa>, IPessoaRepository
    {
        private readonly AppDbContext _dbContext;

        public PessoaRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<Pessoa>> GetAllWithCitiesAsync()
        {
            return await _dbContext.Pessoas.Include(i => i.Cidade).ToListAsync();
        }
    }
}
