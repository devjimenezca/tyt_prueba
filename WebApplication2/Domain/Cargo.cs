using WebApplication2.Domain.Common;

namespace WebApplication2.Domain
{
    public class Cargo : BaseDomainModel
    {
        public int CargoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
