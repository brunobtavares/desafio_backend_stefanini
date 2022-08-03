using desafio_backend_stefanini.Application.DTOs;
using desafio_backend_stefanini.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace desafio_backend_stefanini.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeClient _cidadeClient;

        public CidadeController(ICidadeClient cidadeClient)
        {
            _cidadeClient = cidadeClient ?? throw new ArgumentNullException(nameof(cidadeClient));
        }
        [HttpGet]
        public async Task<CidadeDTO[]> ge()
        {
            return await _cidadeClient.GetAllAsync();
        }

        [HttpPost("incluir")]
        public async Task<CidadeDTO> InlcuirAsync(IncluirCidadeDTO dto)
        {
            return await _cidadeClient.InlcuirAsync(dto);
        }

        [HttpPut("alterar")]
        public async Task<CidadeDTO> AlterarAsync(AlterarCidadeDTO dto)
        {
            return await _cidadeClient.AlterarAsync(dto);
        }

        [HttpDelete("{id}")]
        public async Task<CidadeDTO> RemoverAsync(Guid id)
        {
            return await _cidadeClient.RemoverAsync(id);
        }

        [HttpGet("{id}")]
        public async Task<CidadeDTO> GetByIdAsync(Guid id)
        {
            return await _cidadeClient.GetByIdAsync(id);
        }

        [HttpGet("getAll")]
        public async Task<CidadeDTO[]> GetAllAsync()
        {
            return await _cidadeClient.GetAllAsync();
        }
    }
}