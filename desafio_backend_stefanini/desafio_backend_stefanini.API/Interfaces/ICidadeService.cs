using desafio_backend_stefanini.API.Models;
using desafio_backend_stefanini.Application.DTOs;

namespace desafio_backend_stefanini.API.Interfaces
{
    public interface ICidadeService
    {
        Task<IEnumerable<Cidade>> GetAllAsync();
        Task<Cidade> GetByIdAsync(Guid id);
        Task<Cidade> IncluirAsync(IncluirCidadeDTO dto);
        Task<Cidade> AlterarAsync(AlterarCidadeDTO entity);
        Task<Cidade> RemoverAsync(Guid id);
    }
}
