using Microsoft.EntityFrameworkCore;
using WebApplication2.Domain;
using WebApplication2.DTOs;
using WebApplication2.Persistence;

namespace WebApplication2.Repository
{
    public class UsuarioRepository
    {
       protected readonly DataDbContext _context;


        public  async Task<Usuario?> GetClienteByIdent(string identificacion)
        {
            return await _context!.Usuario!.Where(o => o.Identificacion == identificacion).FirstOrDefaultAsync();
        }

        public async Task<List<Usuario>> GetClienteAll()
        {
            using (var _context = new DataDbContext())
            {
                return await _context!.Usuario!.ToListAsync();
            }
            return new List<Usuario>();
        }

        public  UsuarioDTO SaveUsuario(UsuarioDTO usuario)
        {
            using (var _context = new DataDbContext())
            {

                var newUsuario = new Usuario()
                {
                    Identificacion = usuario.Identificacion,
                    Id = usuario.Id,
                    UsuarioName = usuario.UsuarioName,
                    PrimerApellido = usuario.PrimerApellido,
                    SegundoApellido = usuario.SegundoApellido,
                    PrimerNombre = usuario.PrimerNombre,
                    SegundoNombre = usuario.SegundoNombre,
                    DepartamentoId = usuario.DepartamentoId,
                    CargoId = usuario.CargoId,
                    Estado = true
            };
                _context.Usuario.Add(newUsuario);

                _context.SaveChanges();
                return usuario;
            }
           

        }

        public async Task<UsuarioDTO> UpdateUsuario(UsuarioDTO usuario)
        {
            using (var _context = new DataDbContext())
            {
                var entidad = _context!.Usuario!.Where(d => d.Id == usuario.Id).First();
                entidad.UsuarioName = usuario.UsuarioName;
                entidad.PrimerApellido = usuario.PrimerApellido;
                entidad.SegundoApellido = usuario.SegundoApellido;
                entidad.PrimerNombre = usuario.PrimerNombre;
                entidad.SegundoNombre = usuario.SegundoNombre;
                entidad.DepartamentoId = usuario.DepartamentoId;
                entidad.CargoId = usuario.CargoId;
                entidad.Estado = usuario.Estado;
                _context.SaveChanges();
                return usuario;
            }
           

        }

        public async Task<Boolean> DeleteUsuario(int idUsuario)
        {
            using (var _context = new DataDbContext())
            {
                var entidad = _context!.Usuario!.Single(x => x.Id == idUsuario);
                entidad.Estado = false;
                _context.SaveChanges();
                return true;
            }

        }
    }
}
