using WebApplication2.Domain.Common;

namespace WebApplication2.Domain
{
    public class Usuario : BaseDomainModel
    {
        public string Identificacion { get; set; }
        public int Id { get; set; }
        public string UsuarioName { get; set; }

        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Cargo Cargo { get; set; }

    }
}
