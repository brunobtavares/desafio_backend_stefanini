using desafio_backend_stefanini.API.Interfaces;
using desafio_backend_stefanini.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace desafio_backend_stefanini.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService ?? throw new ArgumentNullException(nameof(pessoaService));
        }

        /// <summary>
        /// Inclui uma nova pessoa
        /// </summary>        
        [HttpPost("Incluir")]
        public async Task<IActionResult> InlcuirAsync([FromBody] IncluirPessoaDTO dto)
        {
            try
            {
                return Ok(await _pessoaService.IncluirAsync(dto));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        /// <summary>
        /// Altera dados da pessoa
        /// </summary>
        [HttpPut("Alterar")]
        public async Task<IActionResult> AlterarAsync([FromBody] AlterarPessoaDTO dto)
        {
            try
            {
                return Ok(await _pessoaService.AlterarAsync(dto));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Remove pessoa por ID
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoverAsync(Guid id)
        {
            try
            {
                return Ok(await _pessoaService.RemoverAsync(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Busca pessoa por ID
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            try
            {
                return Ok(await _pessoaService.GetByIdAsync(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Busca todas as pessoas (com as cidades)
        /// </summary>
        [HttpGet("GetAllWithCities")]
        public async Task<IActionResult> GetAllWithCitiesAsync()
        {
            try
            {
                return Ok(await _pessoaService.GetAllWithCitiesAsync());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        /// <summary>
        /// Busca todas as pessoas (somente com cidadeId, sem as cidades)
        /// </summary>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                return Ok(await _pessoaService.GetAllAsync());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}
