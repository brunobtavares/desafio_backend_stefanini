using desafio_backend_stefanini.API.Interfaces;

namespace desafio_backend_stefanini.API.Models
{
    public class Pessoa : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Cpf { get; set; }


        public Guid CidadeId { get; set; }
        public Cidade Cidade { get; set; }

    }
}
