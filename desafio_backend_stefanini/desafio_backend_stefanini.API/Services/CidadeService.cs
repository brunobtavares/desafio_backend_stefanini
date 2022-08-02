using AutoMapper;
using desafio_backend_stefanini.API.Interfaces;
using desafio_backend_stefanini.API.Models;
using desafio_backend_stefanini.Application.DTOs;

namespace desafio_backend_stefanini.API.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IMapper _mapper;

        public CidadeService(ICidadeRepository cidadeRepository, IMapper mapper)
        {
            _cidadeRepository = cidadeRepository ?? throw new ArgumentNullException(nameof(cidadeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Cidade> IncluirAsync(IncluirCidadeDTO dto)
        {
            var entity = _mapper.Map<Cidade>(dto);
            return await _cidadeRepository.CreateAsync(entity);
        }

        public async Task<Cidade> RemoverAsync(Guid id)
        {
            return await _cidadeRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Cidade>> GetAllAsync()
        {
            return await _cidadeRepository.GetAllAsync();
        }

        public async Task<Cidade> GetByIdAsync(Guid id)
        {
            return await _cidadeRepository.GetByIdAsync(id);
        }

        public async Task<Cidade> AlterarAsync(AlterarCidadeDTO dto)
        {
            var entity = _mapper.Map<Cidade>(dto);
            return await _cidadeRepository.UpdateAsync(entity);
        }
    }
}
