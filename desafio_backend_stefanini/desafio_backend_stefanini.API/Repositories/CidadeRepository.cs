using desafio_backend_stefanini.API.Data;
using desafio_backend_stefanini.API.Interfaces;
using desafio_backend_stefanini.API.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace desafio_backend_stefanini.API.Repositories
{
    public class CidadeRepository : GenericRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
