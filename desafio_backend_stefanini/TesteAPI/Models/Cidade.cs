using desafio_backend_stefanini.API.Interfaces;

namespace desafio_backend_stefanini.API.Models
{
    public class Cidade : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Uf { get; set; }
    }
}
