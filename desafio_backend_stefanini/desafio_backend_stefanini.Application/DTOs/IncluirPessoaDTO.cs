namespace desafio_backend_stefanini.Application.DTOs
{
    public class IncluirPessoaDTO
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Guid CidadeId { get; set; }
    }
}
