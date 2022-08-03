using desafio_backend_stefanini.Application.DTOs;
using desafio_backend_stefanini.Interfaces;
using Refit;

namespace desafio_backend_stefanini.Application.Clients
{
    public class CidadeClient : ICidadeClient
    {
        private readonly ICidadeClient _api;
        public CidadeClient(string apiUrl)
        {
            _api = RestService.For<ICidadeClient>(apiUrl);
        }

        public async Task<CidadeDTO> AlterarAsync(AlterarCidadeDTO dto)
        {
            return await this._api.AlterarAsync(dto);
        }

        public async Task<CidadeDTO[]> GetAllAsync()
        {
            return await _api.GetAllAsync();
        }

        public async Task<CidadeDTO> GetByIdAsync(Guid id)
        {
            return await _api.GetByIdAsync(id);
        }

        public async Task<CidadeDTO> InlcuirAsync(IncluirCidadeDTO dto)
        {
            return await _api.InlcuirAsync(dto);
        }

        public async Task<CidadeDTO> RemoverAsync(Guid id)
        {
            return await _api.RemoverAsync(id);
        }
    }
}
