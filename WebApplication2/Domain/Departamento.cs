using WebApplication2.Domain.Common;

namespace WebApplication2.Domain
{
    public class Departamento: BaseDomainModel
    {
        public int DepartamentoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

    }
}
