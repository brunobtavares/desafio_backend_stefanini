using AutoMapper;
using desafio_backend_stefanini.API.Interfaces;
using desafio_backend_stefanini.API.Models;
using desafio_backend_stefanini.Application.DTOs;

namespace desafio_backend_stefanini.API.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IMapper _mapper;

        public PessoaService(IPessoaRepository pessoaRepository,
                            ICidadeRepository cidadeRepository,
                            IMapper mapper)
        {
            _pessoaRepository = pessoaRepository ?? throw new ArgumentNullException(nameof(pessoaRepository));
            _cidadeRepository = cidadeRepository ?? throw new ArgumentNullException(nameof(cidadeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Pessoa> IncluirAsync(IncluirPessoaDTO dto)
        {
            var cidadeResponse = await _cidadeRepository.GetByIdAsync(dto.CidadeId);

            if (cidadeResponse == null)
                return null;

            var entity = _mapper.Map<Pessoa>(dto);
            return await _pessoaRepository.CreateAsync(entity);
        }

        public async Task<Pessoa> RemoverAsync(Guid id)
        {
            return await _pessoaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Pessoa>> GetAllWithCitiesAsync()
        {
            return await _pessoaRepository.GetAllWithCitiesAsync();
        }
        
        public async Task<IEnumerable<Pessoa>> GetAllAsync()
        {
            return await _pessoaRepository.GetAllAsync();
        }

        public async Task<Pessoa> GetByIdAsync(Guid id)
        {
            return await _pessoaRepository.GetByIdAsync(id);
        }

        public async Task<Pessoa> AlterarAsync(AlterarPessoaDTO dto)
        {
            var entity = _mapper.Map<Pessoa>(dto);
            return await _pessoaRepository.UpdateAsync(entity);
        }
    }
}
