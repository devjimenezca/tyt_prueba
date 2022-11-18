using WebApplication2.Domain.Common;

namespace WebApplication2.DTOs
{
    public class UsuarioDTO
    {
        public string Identificacion { get; set; }
        public int Id { get; set; }
        public string UsuarioName { get; set; }

        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }


        public int DepartamentoId { get; set; }
        public int CargoId { get; set; }
        public bool Estado { get; set; }


    }
}
