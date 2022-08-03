using desafio_backend_stefanini.Application.DTOs;
using Refit;

namespace desafio_backend_stefanini.Interfaces
{
    public interface IPessoaClient
    {
        [Post("/pessoa/incluir")]
        Task<PessoaDTO> InlcuirAsync(IncluirPessoaDTO dto);

        [Put("/pessoa/alterar")]
        Task<PessoaDTO> AlterarAsync(AlterarPessoaDTO dto);

        [Delete("/pessoa/{id}")]
        Task<PessoaDTO> RemoverAsync(Guid id);

        [Get("/pessoa/{id}")]
        Task<PessoaDTO> GetByIdAsync(Guid id);

        [Get("/pessoa/getAllWithCities")]
        Task<PessoaDTO[]> GetAllWithCitiesAsync();

        [Get("/pessoa/getAll")]
        Task<PessoaDTO[]> GetAllAsync();
    }
}
