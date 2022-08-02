namespace desafio_backend_stefanini.Application.DTOs
{
    public class AlterarPessoaDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Guid CidadeId { get; set; }
    }
}
