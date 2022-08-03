using desafio_backend_stefanini.Application.DTOs;
using desafio_backend_stefanini.Interfaces;
using Refit;

namespace desafio_backend_stefanini.Application.Clients
{
    public class PessoaClient : IPessoaClient
    {
        private readonly IPessoaClient _api;
        public PessoaClient(string apiUrl)
        {
            _api = RestService.For<IPessoaClient>(apiUrl);
        }

        public async Task<PessoaDTO> AlterarAsync(AlterarPessoaDTO dto)
        {
            return await this._api.AlterarAsync(dto);
        }

        public async Task<PessoaDTO[]> GetAllAsync()
        {
            return await _api.GetAllAsync();
        }

        public async Task<PessoaDTO[]> GetAllWithCitiesAsync()
        {
            return await _api.GetAllWithCitiesAsync();
        }

        public async Task<PessoaDTO> GetByIdAsync(Guid id)
        {
            return await _api.GetByIdAsync(id);
        }

        public async Task<PessoaDTO> InlcuirAsync(IncluirPessoaDTO dto)
        {
            return await _api.InlcuirAsync(dto);
        }

        public async Task<PessoaDTO> RemoverAsync(Guid id)
        {
            return await _api.RemoverAsync(id);
        }
    }
}
