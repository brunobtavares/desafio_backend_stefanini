using desafio_backend_stefanini.Application.DTOs;
using Refit;

namespace desafio_backend_stefanini.Interfaces
{
    public interface ICidadeClient
    {
        [Post("/cidade/incluir")]
        Task<CidadeDTO> InlcuirAsync(IncluirCidadeDTO dto);

        [Put("/cidade/alterar")]
        Task<CidadeDTO> AlterarAsync(AlterarCidadeDTO dto);

        [Delete("/cidade/{id}")]
        Task<CidadeDTO> RemoverAsync(Guid id);

        [Get("/cidade/{id}")]
        Task<CidadeDTO> GetByIdAsync(Guid id);

        [Get("/cidade/getAll")]
        Task<CidadeDTO[]> GetAllAsync();
    }
}
