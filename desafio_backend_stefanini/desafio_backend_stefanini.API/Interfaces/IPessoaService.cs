using desafio_backend_stefanini.API.Models;
using desafio_backend_stefanini.Application.DTOs;

namespace desafio_backend_stefanini.API.Interfaces
{
    public interface IPessoaService
    {
        Task<IEnumerable<Pessoa>> GetAllWithCitiesAsync();
        Task<IEnumerable<Pessoa>> GetAllAsync();
        Task<Pessoa> GetByIdAsync(Guid id);
        Task<Pessoa> IncluirAsync(IncluirPessoaDTO dto);
        Task<Pessoa> AlterarAsync(AlterarPessoaDTO entity);
        Task<Pessoa> RemoverAsync(Guid id);
    }
}
