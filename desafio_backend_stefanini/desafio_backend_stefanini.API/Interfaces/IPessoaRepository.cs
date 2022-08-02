using desafio_backend_stefanini.API.Models;

namespace desafio_backend_stefanini.API.Interfaces
{
    public interface IPessoaRepository : IGenericRepository<Pessoa>
    {
        Task<IEnumerable<Pessoa>> GetAllWithCitiesAsync();
    }
}
