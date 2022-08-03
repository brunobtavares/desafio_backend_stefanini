using desafio_backend_stefanini.Application.DTOs;
using desafio_backend_stefanini.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace desafio_backend_stefanini.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaClient _pessoaClient;

        public PessoaController(IPessoaClient pessoaClient)
        {
            _pessoaClient = pessoaClient ?? throw new ArgumentNullException(nameof(pessoaClient));
        }

        [HttpPost("incluir")]
        public async Task<PessoaDTO> InlcuirAsync(IncluirPessoaDTO dto)
        {
            return await _pessoaClient.InlcuirAsync(dto);
        }

        [HttpPut("alterar")]
        public async Task<PessoaDTO> AlterarAsync(AlterarPessoaDTO dto)
        {
            return await _pessoaClient.AlterarAsync(dto);
        }

        [HttpDelete("{id}")]
        public async Task<PessoaDTO> RemoverAsync(Guid id)
        {
            return await _pessoaClient.RemoverAsync(id);
        }

        [HttpGet("{id}")]
        public async Task<PessoaDTO> GetByIdAsync(Guid id)
        {
            return await _pessoaClient.GetByIdAsync(id);
        }

        [HttpGet("getAllWithCities")]
        public async Task<PessoaDTO[]> GetAllWithCitiesAsync()
        {
            return await _pessoaClient.GetAllWithCitiesAsync();
        }

        [HttpGet("getAll")]
        public async Task<PessoaDTO[]> GetAllAsync()
        {
            return await _pessoaClient.GetAllAsync();
        }
    }
}